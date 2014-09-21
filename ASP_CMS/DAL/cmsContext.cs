using ASP_CMS.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ASP_CMS.DAL
{
    public class CmsContext : DbContext
    {
        public CmsContext() : base("CmsContext")
        {
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<User> Users { get; set; }

    }
}