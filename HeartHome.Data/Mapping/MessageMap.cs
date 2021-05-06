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
    public class MessageMap : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("message")
                .HasKey(c => c.MessageID);
            builder.Property(c => c.MessageID)
                .HasColumnName("message_id");
            builder.Property(c => c.TenantID)
                .HasColumnName("tenant_id");
            builder.Property(c => c.LessorID)
                .HasColumnName("lessor_id");
            builder.Property(c => c.Content)
                .HasColumnName("content")
                .IsUnicode(false)
                .HasMaxLength(50);

            //FK  //Tabla con FK es public virtual
            //la otra es con Icollection

            builder.HasOne(c => c.Lessor)
                .WithMany(c => c.Messages)
                .HasForeignKey(c => c.LessorID)
                .HasConstraintName("fk_message_lessor")
                .IsRequired(true);
            builder.HasOne(c => c.Tenant)
                .WithMany(c => c.Messages)
                .HasForeignKey(c => c.TenantID)
                .HasConstraintName("fk_message_tenant")
                .IsRequired(true);
        }
    }
}
