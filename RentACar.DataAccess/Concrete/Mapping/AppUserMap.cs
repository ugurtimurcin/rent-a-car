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
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.FirstName).HasMaxLength(20).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(25).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(30).IsRequired();
            builder.Property(x => x.FirstName).IsRequired();

            builder.HasData(
                new AppUser { Id = 1, FirstName = "Ugur", LastName = "Timurçin", UserName = "oxir", Email = "utimurcin@outlook.com", Password = "Ugur.123" },
                new AppUser { Id = 2, FirstName = "Baran", LastName = "Timurçin", UserName = "oxir", Email = "barantimurcin@outlook.com", Password = "Baran.123" }
                );
        }
    }
}
