using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class FormData
    {
        [Required]
        [RegularExpression("^[0-9А-Яа-яёЁA-Za-z -]+$",ErrorMessage = "Допустимые символы буквы, цифры, тире и пробелы.")]
        public string Name { get; set; }
        public string Gender { get; set; }
        public bool English { get; set; }
        public bool French { get; set; }
        public bool Germany { get; set; }
        [Required]
        public string About { get; set; }
    }
}