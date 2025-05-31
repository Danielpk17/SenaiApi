using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Mappers
{
    public class EnderecoMapper
    {
        public class EnderecosMapper : Profile
        {
            public EnderecosMapper()
            {
         
                CreateMap<EnderecoDTo, Endereco>().ReverseMap();

            }
        }
    }
}
