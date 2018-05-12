using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength=1)]
        public string Author { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Text { get; set; }
    }
}