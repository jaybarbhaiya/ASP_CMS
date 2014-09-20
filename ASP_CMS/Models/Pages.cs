using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_CMS.Models
{
    public class Pages
    {
        public int Id { get; set; }
        public int subject_Id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public bool visible { get; set; }

        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}