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

        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Pages> Pages { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}