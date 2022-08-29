using System;
using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Dtos;
using AutoMapper;
using Domain.Entities.Concrete;

namespace Application.Features.Brands.Profiles
{
  public class MappingProfiles : Profile
  {
    public MappingProfiles()
    {
      CreateMap<Brand, CreatedBrandDto>().ReverseMap();
      CreateMap<Brand, CreateBrandCommand>().ReverseMap();
    }
  }
}
