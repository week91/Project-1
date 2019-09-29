using HappyNews.Models;

namespace HappyNews.Repo
{
    public class Usersrepo: EntityFrameworkRepo<Users>
    {
        Usersrepo(DbContent _content) : base(_content)
        {

        }
    }
}
