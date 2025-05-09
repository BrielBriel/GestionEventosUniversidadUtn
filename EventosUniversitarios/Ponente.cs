using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosUniversitarios
{
    public class Ponente
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Biografia { get; set; }
        public string? Correo { get; set; }
        public List<Sesion>? SesionesAsignadas { get; set; }

    }
}
