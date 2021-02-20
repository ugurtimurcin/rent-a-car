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
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.AppUserId).IsUnique();

            builder.Property(x => x.CompanyName).HasMaxLength(75).IsRequired();

            builder.HasData(
                new Customer { Id = 1, CompanyName="Oxir Co.", AppUserId = 1},
                new Customer { Id = 2, CompanyName="Baran Co.", AppUserId = 2}
                );
        }
    }
}
