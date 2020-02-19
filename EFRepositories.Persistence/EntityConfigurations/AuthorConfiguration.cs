using EFRepositories.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EFRepositories.Persistence.EntityConfigurations
{
    public class AuthorConfiguration : EntityTypeConfiguration<Author>
    {
        public AuthorConfiguration()
        {
            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
