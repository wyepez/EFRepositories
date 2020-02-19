using EFRepositories.Core.Domain;
using EFRepositories.Persistence.EntityConfigurations;
using System.Data.Entity;

namespace EFRepositories.Persistence
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("name=DefaultConnection") { }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorConfiguration());
            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
        }
    }
}
