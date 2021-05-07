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
    public class CommentPropertyMap : IEntityTypeConfiguration<CommentProperty>
    {
        public void Configure(EntityTypeBuilder<CommentProperty> builder)
        {
            builder.ToTable("comment_property")
                .HasKey(c => c.CommentID);
            builder.Property(c => c.CommentID)
                .HasColumnName("comment_id");
            builder.Property(c => c.TenantID)
                .HasColumnName("tenant_id");
            builder.Property(c => c.Detail)
                .HasColumnName("detail")
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(c => c.Date)
                .HasColumnName("date_comment")
                .HasColumnType("string");

            //FK

            builder.HasOne(c => c.Tenant)
                .WithMany(c => c.CommentProperties)
                .HasForeignKey(c => c.TenantID)
                .HasConstraintName("fk_tenant_commentproperty")
                .IsRequired(true);
        }
    }
}
