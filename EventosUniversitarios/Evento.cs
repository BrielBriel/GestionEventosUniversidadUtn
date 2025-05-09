using System.ComponentModel.DataAnnotations;

namespace EventosUniversitarios
{
    public class Evento
    {

        [Key] public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Lugar { get; set; }
        public List<Sesion>? Sesiones { get; set; }
        public List<Inscripcion>? Inscripciones { get; set; }
        public List<Certificado>? Certificados { get; set; }


    }
}
