using EFRepositories.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EFRepositories.Persistence.EntityConfigurations
{
    public class TagConfiguration : EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
