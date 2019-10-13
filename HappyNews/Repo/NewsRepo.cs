using HappyNews.Models;

namespace HappyNews.Repo
{
    public class NewsRepo:EntityFrameworkRepo<News>
    {
       public NewsRepo(DbContent _content) : base(_content)
        {

        }
    }
}
