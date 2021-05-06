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
    public class PublicationMap : IEntityTypeConfiguration<Publication>
    {
        public void Configure(EntityTypeBuilder<Publication> builder)
        {
            builder.ToTable("publication")
                .HasKey(c => c.PublicationID);
            builder.Property(c => c.PublicationID)
                .HasColumnName("publication_id");
            builder.Property(c => c.PropertyID)
                .HasColumnName("property_id");
            builder.Property(c => c.CommentID)
                .HasColumnName("comment_id");
            builder.Property(c => c.content)
                .HasColumnName("content")
                .HasMaxLength(50)
                .IsUnicode(false);

            //FK

            builder.HasOne(c => c.Property)
                .WithMany(c => c.Publications)
                .HasForeignKey(c => c.PropertyID)
                .HasConstraintName("fk_property_publication")
                .IsRequired(true);
            builder.HasOne(c => c.CommentProperty)
                .WithMany(c => c.Publications)
                .HasForeignKey(c => c.CommentID)
                .HasConstraintName("fk_commentproperty_publication")
                .IsRequired(true);

        }
    }
}
