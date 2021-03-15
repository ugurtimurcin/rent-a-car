using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concrete.Mapping
{
    public class ColorMap : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasMaxLength(20).IsRequired();

            builder.HasData(
                new Color { Id = 1, Name = "Black" },
                new Color { Id = 2, Name = "Gray" },
                new Color { Id = 3, Name = "Red" },
                new Color { Id = 4, Name = "White" }
                );
        }
    }
}
