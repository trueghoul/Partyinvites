using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Partyinvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Введите ваше имя.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите ваш e-mail.")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Повторите попытку ввода e-mail адреса.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите ваш телефон.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Укажите, пожалуйста, пойдете ли вы на вечеринку.")]
        public bool? WillAttend { get; set; }

    }
}

