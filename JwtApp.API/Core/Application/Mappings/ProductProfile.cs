using AutoMapper;
using JwtApp.API.Core.Application.Dtos;
using JwtApp.API.Core.Domain;

namespace JwtApp.API.Core.Application.Mappings
{
    public class ProductProfile :Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}
