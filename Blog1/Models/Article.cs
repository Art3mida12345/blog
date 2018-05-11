using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Article
    {
        private string title;
        public string Title { get => title; set => title = value; }
        private DateTime time;
        public DateTime Time { get => time; set => time = value; }
        private string text;
        public string Text { get => text; set => text = value; }
    }
}