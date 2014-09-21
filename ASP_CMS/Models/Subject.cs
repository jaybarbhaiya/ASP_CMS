using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_CMS.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public bool visible { get; set; }

        public virtual ICollection<Page> Pages { get; set; }
    }
}