using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportStore.Models
{
    public class Order
    {

        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, заполните адрес")]
        public string Line1 { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите ваш город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите ваш регион")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите название страны")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
