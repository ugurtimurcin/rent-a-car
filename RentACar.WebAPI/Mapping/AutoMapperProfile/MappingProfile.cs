using AutoMapper;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Mapping.AutoMapperProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            //Mapping for AppUser entity
            CreateMap<AppUserDto, AppUser>();
            CreateMap<AppUser, AppUserDto>();

            CreateMap<AppUserAddDto, AppUser>();
            CreateMap<AppUser, AppUserAddDto>();

            CreateMap<AppUserUpdateDto, AppUser>();
            CreateMap<AppUser, AppUserUpdateDto>();

            //Mapping for Color entity
            CreateMap<ColorDto, Color>();
            CreateMap<Color, ColorDto>();

            CreateMap<ColorAddDto, Color>();
            CreateMap<Color, ColorAddDto>();

            CreateMap<ColorUpdateDto, Color>();
            CreateMap<Color, ColorUpdateDto>();

            //Mapping for Brand entity
            CreateMap<BrandDto, Brand>();
            CreateMap<Brand, BrandDto>();

            CreateMap<BrandAddDto, Brand>();
            CreateMap<Brand, BrandAddDto>();

            CreateMap<BrandUpdateDto, Brand>();
            CreateMap<Brand, BrandUpdateDto>();

            //Mapping for Car entity
            CreateMap<CarDto, Car>();
            CreateMap<Car, CarDto>();

            CreateMap<CarAddDto, Car>();
            CreateMap<Car, CarAddDto>();

            CreateMap<CarUpdateDto, Car>();
            CreateMap<Car, CarUpdateDto>();

            //Mapping for Rental entity
            CreateMap<RentalDto, Rental>();
            CreateMap<Rental, RentalDto>();

            CreateMap<RentalAddDto, Rental>();
            CreateMap<Rental, RentalAddDto>();

            CreateMap<RentalUpdateDto, Rental>();
            CreateMap<Rental, RentalUpdateDto>();


        }
    }
}
