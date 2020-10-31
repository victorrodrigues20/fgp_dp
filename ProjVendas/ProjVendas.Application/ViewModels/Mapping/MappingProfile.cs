using AutoMapper;
using ProjVendas.Domain.Entities;

namespace ProjVendas.Application.ViewModels.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Categoria, CategoriaViewModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.CategoriaID))
                .ReverseMap();
        }
    }
}