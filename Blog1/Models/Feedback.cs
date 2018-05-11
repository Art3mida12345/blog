using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Feedback
    {
        private string author;
        public string Author { get => author; set => author = value; }
        private DateTime date;
        public DateTime Date { get => date; set => date=value; }
        private string text;
        public string Text { get => text; set => text = value; }
    }
}