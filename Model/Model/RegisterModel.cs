using System.ComponentModel.DataAnnotations;

namespace Model1.Model
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
