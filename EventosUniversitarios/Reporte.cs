using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosUniversitarios
{
    public class Reporte
    {
        [Key] public int Id { get; set; }
        public string? Tipo { get; set; }
        public DateTime? FechaGeneracion { get; set; }
        public string? DatosResumen { get; set; }

    }
}
