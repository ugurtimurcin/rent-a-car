using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using RentACar.Business.Abstract;
using RentACar.Business.Concrete;
using RentACar.Business.ValidationRules.FluentValidation;
using RentACar.Core.Business;
using RentACar.Core.DataAccess;
using RentACar.Core.DataAccess.EntityFramework;
using RentACar.DataAccess.Abstract;
using RentACar.DataAccess.Concrete;
using RentACar.DataAccess.Concrete.EntityFramework;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Containers.MicrosoftIoC
{
    public static class CustomDependencies
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IEntityRepository<AppUser>), typeof(EfEntityRepositoryBase<AppUser, DataContext>));
            services.AddScoped(typeof(IEntityRepository<Color>), typeof(EfEntityRepositoryBase<Color, DataContext>));
            services.AddScoped(typeof(IEntityRepository<Brand>), typeof(EfEntityRepositoryBase<Brand, DataContext>));
            services.AddScoped(typeof(IEntityRepository<Car>), typeof(EfEntityRepositoryBase<Car, DataContext>));
            services.AddScoped(typeof(IEntityRepository<Rental>), typeof(EfEntityRepositoryBase<Rental, DataContext>));

            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IColorDal, EfColorDal>();

            services.AddScoped<IRentalDal, EfRentalDal>();
            services.AddScoped<IRentalService, RentalManager>();


            services.AddTransient<IValidator<AppUserAddDto>, AppUserAddValidator>();
            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateValidator>();

            services.AddTransient<IValidator<ColorAddDto>, ColorAddValidator>();
            services.AddTransient<IValidator<ColorUpdateDto>, ColorUpdateValidator>();

            services.AddTransient<IValidator<BrandAddDto>, BrandAddValidator>();
            services.AddTransient<IValidator<BrandUpdateDto>, BrandUpdateValidator>();

            services.AddTransient<IValidator<CarAddDto>, CarAddValidator>();
            services.AddTransient<IValidator<CarUpdateDto>, CarUpdateValidator>();

            services.AddTransient<IValidator<RentalAddDto>, RentalAddValidator>();
            services.AddTransient<IValidator<RentalUpdateDto>, RentalUpdateValidator>();

            services.AddDbContext<DataContext>();
        }
    }
}
