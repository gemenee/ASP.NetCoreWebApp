using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace MyGreatSite.Domain.Entities
{
    public class Feedback : EntityBase
    {
        [Required(ErrorMessage = "Заполните заголовок отзыва")]
        [Display(Name = "Заголовок отзыва")]
        public override string Title { get; set; }

        [Display(Name = "Автор отзыва")]
        public override string Subtitle { get; set; }

        [Display(Name = "Текст отзыва")]
        public override string Text { get; set; }

        [Display(Name = "Проверено модератором")]
        [UIHint("Boolean")]
        public bool IsChecked { get; set; }
    }
}
