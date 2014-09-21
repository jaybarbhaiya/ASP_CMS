using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ASP_CMS.Models;

namespace ASP_CMS.DAL
{
    public class CmsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CmsContext>
    {
        protected override void Seed(CmsContext context)
        {
            var subjects = new List<Subject>
            {
            new Subject{name="Campus",position=1,visible=true},
            new Subject{name="Cube",position=2,visible=true}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();

            var pages = new List<Page>
            {
            new Page{subject_Id=1,name="Life",position=1,visible=true},
            new Page{subject_Id=1,name="Facilities",position=2,visible=true},
            new Page{subject_Id=2,name="Opening time",position=1,visible=true},
            new Page{subject_Id=2,name="Weekly Special",position=2,visible=true}
            };
            pages.ForEach(s => context.Pages.Add(s));
            context.SaveChanges();

            var users = new List<User>
            {
            new User{first_name="Prasad",last_name="Pomaji",username="prasad",password="password"},
            new User{first_name="Shehar",last_name="Javed",username="Shehzar",password="buddha"},
            new User{first_name="Jay",last_name="Barbhaiya",username="jaybarbhaiya",password="150590"}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}