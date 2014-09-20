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
            var subjects = new List<Subjects>
            {
            new Subjects{name="Campus",position=1,visible=true},
            new Subjects{name="Cube",position=2,visible=true}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();

            var pages = new List<Pages>
            {
            new Pages{subject_Id=1,name="Life",position=1,visible=true},
            new Pages{subject_Id=1,name="Facilities",position=2,visible=true},
            new Pages{subject_Id=2,name="Opening time",position=1,visible=true},
            new Pages{subject_Id=2,name="Weekly Special",position=2,visible=true}
            };
            pages.ForEach(s => context.Pages.Add(s));
            context.SaveChanges();

            var content = new List<Content>
            {
            new Content{page_Id=1,content="Students experience a great amount of activities in which they can participate",visible=true},
            new Content{page_Id=1,content="Students experience a great amount of activities in which they can participate",visible=true},
            new Content{page_Id=2,content="Monday to Saterday",visible=true},
            new Content{page_Id=2,content="Chicken",visible=true}
            };
            content.ForEach(s => context.Content.Add(s));
            context.SaveChanges();

            var users = new List<Users>
            {
            new Users{first_name="Prasad",last_name="Pomaji",username="prasad",password="password"},
            new Users{first_name="Shehar",last_name="Javed",username="Shehzar",password="buddha"},
            new Users{first_name="Jay",last_name="Barbhaiya",username="jaybarbhaiya",password="150590"}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}