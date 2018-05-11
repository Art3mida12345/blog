using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class FormData
    {
        private string name;
        public string Name { get => name; set => name = value; }
        private string gender;
        public string Gender { get => gender; set => gender = value; }
        public bool English { get; set; }
        public bool French { get; set; }
        public bool Germany { get; set; }
        public string About { get; set; }
    }
}