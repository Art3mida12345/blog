using System;

namespace Blog.Models
{
    public class Feedback
    {
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}