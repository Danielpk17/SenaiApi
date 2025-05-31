using SenaiApi.Entidades;
using System.ComponentModel.DataAnnotations;

namespace SenaiApi.DTos
{
    public class ProfessoresDTOEdicao
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        public long EscolaId { get; set; }
        public long id { get; set; }
        [MaxLength(80)]
        public long ProfessorId { get; set; }
    }
}
