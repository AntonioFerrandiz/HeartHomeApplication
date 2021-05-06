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
    public class ContractMap : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("contract")
                .HasKey(c => c.ContractID);
            builder.Property(c => c.ContractID)
                .HasColumnName("contract_id");
            builder.Property(c => c.TenantID)
                .HasColumnName("tenant_id");
            builder.Property(c => c.PropertyID)
                .HasColumnName("property_id");
            builder.Property(c => c.LessorID)
                .HasColumnName("lessor_id");
            builder.Property(c => c.DateContract)
                .HasColumnName("date_contract");
            builder.Property(c => c.detail)
                .HasColumnName("detail")
                .HasMaxLength(50)
                .IsUnicode(false);

            //FK

            builder.HasOne(c => c.Lessor)
               .WithMany(c => c.Contracts)
               .HasForeignKey(c => c.LessorID)
               .HasConstraintName("fk_lessor_contract")
               .IsRequired(true);
            builder.HasOne(c => c.Property)
               .WithMany(c => c.Contracts)
               .HasForeignKey(c => c.PropertyID)
               .HasConstraintName("fk_property_contract")
               .IsRequired(true);
            builder.HasOne(c => c.Tenant)
               .WithMany(c => c.Contracts)
               .HasForeignKey(c => c.TenantID)
               .HasConstraintName("fk_property_contract")
               .IsRequired(true);
        }
    }
}
