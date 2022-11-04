using DevFreela.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Persistences.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("tb_user");
            builder.HasKey(user => user.Id);
            builder.Property(user => user.Id)
                   .ValueGeneratedOnAdd()
                   .UseMySqlIdentityColumn();

            builder
                   .HasMany(x => x.Skills)
                   .WithMany(x => x.Users);
                   
        }
    }
}
