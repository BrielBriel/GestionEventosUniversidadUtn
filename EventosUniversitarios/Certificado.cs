using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosUniversitarios
{
    public class Certificado
    {
        [Key] public int Id { get; set; }
        public string? Codigo { get; set; }
        [ForeignKey("Participante")] public int ParticipanteId { get; set; }
        [ForeignKey("Evento")] public int EventoId { get; set; }
        public DateTime? FechaEmision { get; set; }
        public Participante? Participante { get; set; }
        public Evento? Evento { get; set; }


    }
}
