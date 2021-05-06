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
    public class CityMap : IEntityTypeConfiguration<City>
    {
       public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("city")
                .HasKey(c => c.CityID);
            builder.Property(c => c.CityID)
                .HasColumnName("city_id");
            builder.Property(c => c.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(c => c.Country)
                .HasColumnName("country")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
