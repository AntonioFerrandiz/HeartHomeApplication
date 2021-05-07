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
    public class BankMap : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.ToTable("bank")
                .HasKey(c => c.BankID);
            builder.Property(c => c.BankID)
                .HasColumnType("bank_id");
            builder.Property(c => c.Name)
                .HasColumnName("name")
                .IsUnicode(false);
        }
    }
}
