using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyGreatSite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [BindNever]
        public bool Shipped { get; set; }
        
        [Required(ErrorMessage ="Введите имя")]
        [Display(Name = "Имя:")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите адрес электронной почты")]
        [Display(Name = "Адрес электронной почты:")]
        [DataType(DataType.EmailAddress)]
        //[EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите номер телефона")]
        [Display(Name = "Номер телефона:")]
        [DataType(DataType.PhoneNumber)]
        //[Phone]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Введите название страны")]
        [Display(Name = "Страна:")]
        public string Country { get; set; }

        //[Required(ErrorMessage = "Введите название региона / области")]
        [Display(Name = "Регион / область")]
        public string State { get; set; }

        [Required(ErrorMessage = "Введите название города")]
        [Display(Name = "Город:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Введите адрес")]
        [Display(Name = "Адрес:")]
        public string Line1 { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Индекс:")]
        public string Zip { get; set; }
        [Display(Name = "Вам завернуть в подарочную упаковку?")]
        public bool GiftWrap { get; set; }
    }
}
