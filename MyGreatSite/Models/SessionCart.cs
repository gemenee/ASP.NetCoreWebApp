﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyGreatSite.Domain.Entities;
using MyGreatSite.Service;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace MyGreatSite.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }
        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session.SetJson("Cart", this);
        }


        public override void RemoveLine(Guid Id)
        {
            base.RemoveLine(Id);
            Session.SetJson("Cart", this);
        }
        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
