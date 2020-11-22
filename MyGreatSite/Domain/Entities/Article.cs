using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Domain.Entities
{
    public class Article : EntityBase
    {
        [Required(ErrorMessage = "Заполните поле заголовка")]
        [Display(Name = "Заголовок статьи")]
        public override string Title { get; set; }

        [Display(Name = "Подзаголовок")]
        public override string Subtitle { get; set; }

        [Display(Name = "Текст статьи")]
        public override string Text { get; set; }

    }
}
