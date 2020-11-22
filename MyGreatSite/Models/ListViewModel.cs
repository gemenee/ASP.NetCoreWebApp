using MyGreatSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Models
{
    public class ListViewModel
    {
        public IEnumerable<EntityBase> Items { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}