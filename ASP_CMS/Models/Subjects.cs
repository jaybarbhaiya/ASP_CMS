using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_CMS.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public bool visible { get; set; }

        public virtual ICollection<Pages> Pages { get; set; }
    }
}