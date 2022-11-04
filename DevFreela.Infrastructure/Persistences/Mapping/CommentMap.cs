using DevFreela.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Persistences.Mapping
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {

            builder.ToTable("tb_comment");
            builder.HasKey(comment => comment.Id);
            builder.Property(comment => comment.Id)
                   .ValueGeneratedOnAdd()
                   .UseMySqlIdentityColumn();

            builder
               .HasOne(p => p.Project)
               .WithMany(p => p.Comments)
               .HasConstraintName("FK_Project_Comment");


            builder
               .HasOne(p => p.User)
               .WithMany(p => p.Comments)
               .HasConstraintName("FK_Project_User");
        }
    }
}
