using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosUniversitarios
{
    public class Sesion
    {

        [Key] public int Id { get; set; }
        [ForeignKey("Evento")] public int EventoId { get; set; }
        public string? Titulo { get; set; }
        public DateTime? FechaHora { get; set; }
        public string? Ubicacion { get; set; }
        public Evento? Evento { get; set; }
        public List<Ponente>? Ponentes { get; set; }

    }
}
