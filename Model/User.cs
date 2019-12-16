using Microsoft.AspNetCore.Identity;

namespace Model1
{
    public class User : IdentityUser

    {
        public string FullName { get; set; }

    }
}
