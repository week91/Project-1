using System;
using HappyNews.Entities;

namespace HappyNews.Models
{
    public class Comments:DbEntities

    {
    public Guid IdComments { get; set; }
    public DateTime DateOfCreate { get; set; }
    public string CommentText { get; set; }
    public Guid UseriD { get; set; }
    public Users User { get; set; }
    public Guid NewsId { get; set; }
    public News News { get; set; }

    }
}
