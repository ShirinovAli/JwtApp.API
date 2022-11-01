using AutoMapper;
using JwtApp.API.Core.Application.Dtos;
using JwtApp.API.Core.Domain;

namespace JwtApp.API.Core.Application.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}
