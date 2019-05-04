using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(5)]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
