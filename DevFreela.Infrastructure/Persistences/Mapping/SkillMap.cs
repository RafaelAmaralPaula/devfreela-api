using DevFreela.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Persistences.Mapping
{
    public class SkillMap : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("tb_skill");
            builder.HasKey(skill => skill.Id);
            builder.Property(skill => skill.Id)
                   .ValueGeneratedOnAdd()
                   .UseMySqlIdentityColumn();

            builder
                   .HasMany(x => x.Users)
                   .WithMany(x => x.Skills);
        }
    }
}
