using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosUniversitarios
{
    public class Participante
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public List<Inscripcion>? Inscripciones { get; set; }
        public List<Certificado>? Certificados { get; set; }

    }
}
