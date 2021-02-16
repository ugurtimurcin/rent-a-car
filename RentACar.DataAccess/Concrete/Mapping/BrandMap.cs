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
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasMaxLength(30).IsRequired();

            builder.HasData(
                new Brand { Id = 1, Name = "Audi" },
                new Brand { Id = 2, Name = "BMW" },
                new Brand { Id = 3, Name = "Renault" }
                );
        }
    }
}
