using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_CMS.Models
{
    public class User
    {
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}