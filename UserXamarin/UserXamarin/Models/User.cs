using System;
using System.Collections.Generic;

namespace UserXamarin.Models
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
        public string full_name { get { return first_name + " " + last_name; } }
    }

    public class Root
    {
        public int page { get; set; }
        public int total_pages { get; set; }
        public List<User> data { get; set; }
    }
}

