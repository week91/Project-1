using System.ComponentModel.DataAnnotations;

namespace HappyNews.ViewsModel
{
    public class EditVM
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string FullName { get; set; }
    }
}
