using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApi.Model
{
    public class RegisterModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = " PASSWORD_MIN_LENGTH 6", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
