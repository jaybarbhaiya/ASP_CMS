using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_CMS.Models
{
    public class Content
    {
        public int Id { get; set; }
        public int page_Id { get; set; }
        public string content { get; set; }
        public bool visible { get; set; }

        public virtual ICollection<Pages> Pages { get; set; }
    }
}