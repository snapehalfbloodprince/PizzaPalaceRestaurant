using AutoMapper;
using PizzaPalace.Services.ProductAPI.Models;
using PizzaPalace.Services.ProductAPI.Models.DTO;

namespace PizzaPalace.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
