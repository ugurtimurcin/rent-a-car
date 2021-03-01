using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Core.Entities.Concrete;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concrete.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasColumnType("varchar(50)");
            builder.Property(x => x.FirstName).HasMaxLength(50);

            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasColumnType("varchar(50)");
            builder.Property(x => x.LastName).HasMaxLength(50);

            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar(50)");
            builder.Property(x => x.Email).HasMaxLength(50);

            builder.Property(x => x.PasswordSalt).IsRequired();
            builder.Property(x => x.PasswordSalt).HasColumnType("binary(500)");
            builder.Property(x => x.PasswordSalt).HasMaxLength(500);

            builder.Property(x => x.PasswordHash).IsRequired();
            builder.Property(x => x.PasswordHash).HasColumnType("binary(500)");
            builder.Property(x => x.PasswordHash).HasMaxLength(500);

            builder.Property(x => x.State).IsRequired();
        }
    }
}
