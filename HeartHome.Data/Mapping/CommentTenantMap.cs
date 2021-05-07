using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HeartHome.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Data.Mapping
{
    public class CommentTenantMap : IEntityTypeConfiguration<CommentTenant>
    {
        public void Configure(EntityTypeBuilder<CommentTenant> builder)
        {
            builder.ToTable("comment_tenant")
                .HasKey(c => c.CommentID);
            builder.Property(c => c.LessorID)
                .HasColumnName("lessor_id");
            builder.Property(c => c.Detail)
                .HasColumnName("detail")
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(c => c.Date)
                .HasColumnName("date_comment")
                .HasColumnType("date");

            //FK

            builder.HasOne(c => c.Lessor)
               .WithMany(c => c.CommentTenants)
               .HasForeignKey(c => c.LessorID)
               .HasConstraintName("fk_commenttenant_lessor")
               .IsRequired(true);

        }
    }
}
