using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_CMS.Models
{
    public class Page
    {
        public int Id { get; set; }
        public int subject_Id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public bool visible { get; set; }
        public string pageContent { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}