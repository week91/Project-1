using HappyNews.Models;

namespace HappyNews.Repo
{
    public class Usersrepo: EntityFrameworkRepo<Users>
    {
      public  Usersrepo(DbContent _content) : base(_content)
        {

        }
    }
}
