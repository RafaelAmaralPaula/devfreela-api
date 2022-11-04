using DevFreela.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Persistences.Mapping
{
    public class ProjectMap : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("tb_project");
            builder.HasKey(project => project.Id);

            builder.Property(project => project.Id)
                   .ValueGeneratedOnAdd()
                   .UseMySqlIdentityColumn();

            builder
                .HasOne(p => p.Freelancer)
                .WithMany(f => f.FreelanceProjects)
                .HasConstraintName("FK_Project_Freelancer");


            builder
                .HasOne(p => p.Client)
                .WithMany(f => f.OwnedProjects)
                .HasConstraintName("FK_Project_Client");


        }
    }
}
