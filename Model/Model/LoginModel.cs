using System.ComponentModel.DataAnnotations;

namespace Model1.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}
