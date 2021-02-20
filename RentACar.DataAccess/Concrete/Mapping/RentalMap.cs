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
    public class RentalMap : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();


            builder.HasData(
                new Rental { Id = 1, CustomerId=1, CarId = 1, RentDate = new DateTime(2021, 2, 14), ReturnDate = new DateTime(2021, 2, 16) },
                new Rental { Id = 2, CustomerId =2, CarId = 2, RentDate = new DateTime(2021, 2, 16), ReturnDate = new DateTime(2021, 2, 19) }
                );
        }
    }
}
