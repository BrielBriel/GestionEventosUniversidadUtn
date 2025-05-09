using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosUniversitarios
{
    public class Pago
    {
        [Key] public int Id { get; set; }
        [ForeignKey("Inscripcion")] public int InscripcionId { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaPago { get; set; }
        public string? MetodoPago { get; set; }

        public Inscripcion? Inscripcion { get; set; }
    }
}
