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
    public class LessorMap : IEntityTypeConfiguration<Lessor>
    {
        public void Configure(EntityTypeBuilder<Lessor> builder)
        {
            builder.ToTable("lessor")
                .HasKey(c => c.LessorID);
            builder.Property(c => c.LessorID)
                .HasColumnName("lessor_id");
            builder.Property(c => c.AccountID)
                .HasColumnName("account_id");
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
                .WithMany(c => c.Lessors)
                .HasForeignKey(c => c.AccountID)
                .HasConstraintName("fk_lessor_bankaccount")
                .IsRequired(true);
        }
    }
}
