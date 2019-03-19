using System.Data.Entity;

namespace LinqIntroductionApps
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DataSource")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
