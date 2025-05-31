using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Mappers
{
    public class ProfessoresMapper : Profile
    {
        public ProfessoresMapper()
        {

            CreateMap<ProfessorDTO, Professor>().ReverseMap();

        }
    }
}
