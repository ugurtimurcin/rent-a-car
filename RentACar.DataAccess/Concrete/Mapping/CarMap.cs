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
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ModelYear).IsRequired();
            builder.Property(x => x.DailyPrice).IsRequired();
            builder.Property(x => x.Description).HasColumnType("varchar(max)").IsRequired();


            builder.HasData(
                new Car { Id = 1, ModelYear = 2019, DailyPrice = 350, Description = "perfect", BrandId = 1, ColorId = 1 },
                new Car { Id = 2, ModelYear = 2020, DailyPrice = 400, Description = "perfect", BrandId = 3, ColorId = 2 },
                new Car { Id = 3, ModelYear = 2021, DailyPrice = 200, Description = "perfect", BrandId = 3, ColorId = 3 }
                );
        }
    }
}
