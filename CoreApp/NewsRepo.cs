using Model1;

namespace CoreApp
{
    public class NewsRepo:EntityFrameworkRepo<News>
    {
       public NewsRepo(DbContent _content) : base(_content)
        {

        }
    }
}
