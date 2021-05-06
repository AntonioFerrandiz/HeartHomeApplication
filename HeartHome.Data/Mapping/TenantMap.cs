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
    public class TenantMap : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.ToTable("tenant")
                .HasKey(c => c.TenantID);
            builder.Property(c => c.TenantID)
                .HasColumnName("tenant_id");
            builder.Property(c => c.AccountID)
                .HasColumnName("account_id");
            builder.Property(c => c.CommentID)
                .HasColumnName("comment_id");
            builder.Property(c => c.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(c => c.Lastname)
                .HasColumnName("lastname")
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(c => c.Email)
                .HasColumnName("email")
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(c => c.Dni)
                .HasColumnName("dni")
                .HasColumnType("int");
            builder.Property(c => c.Phone)
                .HasColumnName("phone")
                .HasColumnType("int");

            //FK

            builder.HasOne(c => c.BankAccount)
                .WithMany(c => c.Tenants)
                .HasForeignKey(c => c.AccountID)
                .HasConstraintName("fk_tenant_bankaccount")
                .IsRequired(true);
            builder.HasOne(c => c.CommentTenant)
                .WithMany(c => c.Tenants)
                .HasForeignKey(c => c.CommentID)
                .HasConstraintName("fk_tenant_commenttenant")
                .IsRequired(true);
        }
    }
}
