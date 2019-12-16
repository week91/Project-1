using System.ComponentModel.DataAnnotations;

namespace HappyNews.ViewsModel
{
    public class CreatUserVM
    {
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }
    }
}
