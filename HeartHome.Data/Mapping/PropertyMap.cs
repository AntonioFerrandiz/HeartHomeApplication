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
    public class PropertyMap : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.ToTable("property")
                .HasKey(c => c.PropertyID);
            builder.Property(c => c.PropertyID)
                .HasColumnName("property_id");
            builder.Property(c => c.CityID)
                .HasColumnName("city_id");
            builder.Property(c => c.LessorID)
                .HasColumnName("lessor_id");
            builder.Property(c => c.Type)
                .HasColumnName("type")
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(c => c.Address)
                .HasColumnName("address")
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(c => c.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(c => c.Phone)
                .HasColumnName("phone")
                .HasMaxLength(9)
                .HasColumnType("int");

            //FK
            //Tabla con FK es public virtual
            //la otra es con Icollection
            builder.HasOne(c => c.City)
                .WithMany(c => c.Properties)
                .HasForeignKey(c => c.CityID)
                .HasConstraintName("fk_property_city")
                .IsRequired(true);

            builder.HasOne(c => c.Lessor)
                .WithMany(c => c.Properties)
                .HasForeignKey(c => c.LessorID)
                .HasConstraintName("fk_property_lessor")
                .IsRequired(true);
        }
    }
}
