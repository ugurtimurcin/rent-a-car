using AutoMapper;
using RentACar.Core.Entities.Concrete;
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
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserAddDto, User>().ReverseMap();
            CreateMap<UserUpdateDto, User>().ReverseMap();

            CreateMap<ColorDto, Color>().ReverseMap();
            CreateMap<ColorAddDto, Color>().ReverseMap();
            CreateMap<ColorUpdateDto, Color>().ReverseMap();

            CreateMap<BrandDto, Brand>().ReverseMap();
            CreateMap<BrandAddDto, Brand>().ReverseMap();
            CreateMap<BrandUpdateDto, Brand>().ReverseMap();

            CreateMap<CarDto, Car>().ReverseMap();
            CreateMap<CarAddDto, Car>().ReverseMap();
            CreateMap<CarUpdateDto, Car>().ReverseMap();

            CreateMap<RentalDto, Rental>().ReverseMap();
            CreateMap<RentalAddDto, Rental>().ReverseMap();
            CreateMap<RentalUpdateDto, Rental>().ReverseMap();            

            CreateMap<CarImageDto, CarImage>().ReverseMap();



        }
    }
}
