using MVC_Blog_Sitesi.Entites;
using System;

namespace MVC_Blog_Sitesi.Entites
{
    public class Article
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;

        public int? AuthorId { get; set; }
        public AppAuthor Author { get; set; }

    }
}
