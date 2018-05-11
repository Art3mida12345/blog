using System;

namespace DAL.Entities
{
    public class FeedbackD
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
