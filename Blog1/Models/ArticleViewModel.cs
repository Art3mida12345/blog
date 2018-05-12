using System;

namespace Blog1.Models
{
    public class ArticleViewModel
    {
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public string Text { get; set; }
        public string HashTags { get; set; }
    }
}