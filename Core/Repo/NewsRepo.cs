using HappyNews.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repo
{
    public class NewsRepo:EntityFrameworkRepo<News>
    {
       public NewsRepo(DbContent _content) : base(_content)
        {

        }
    }
}
