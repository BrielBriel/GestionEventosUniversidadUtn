using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosUniversitarios
{
    public class Inscripcion
    {
        [Key] public int Id { get; set; }
        [ForeignKey("Evento")] public int EventoId { get; set; }
        [ForeignKey("Participante")] public int ParticipanteId { get; set; }
        public DateTime? FechaInscripcion { get; set; }

        public Evento? Evento { get; set; }
        public Participante? Participante { get; set; }
        public Pago? Pago { get; set; }

    }
}
