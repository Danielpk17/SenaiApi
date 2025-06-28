using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Mappers
{
    public class EscolaMapper : Profile
    {
        public EscolaMapper() 
        {
            CreateMap<EscolaDTo, Escola>()
                .ForMember (dest => dest.Nome, opt => opt.MapFrom(src => src.nome));

            CreateMap<EscolaDTo, Escola>().ReverseMap();

            CreateMap<EnderecoDTo, Endereco>().ReverseMap();
        }   
    }
}
