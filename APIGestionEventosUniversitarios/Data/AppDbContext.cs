using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventosUniversitarios;

    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<EventosUniversitarios.Evento> Evento { get; set; } = default!;

        public DbSet<EventosUniversitarios.Certificado> Certificado { get; set; } = default!;

        public DbSet<EventosUniversitarios.Inscripcion> Inscripcion { get; set; } = default!;

        public DbSet<EventosUniversitarios.Pago> Pago { get; set; } = default!;

        public DbSet<EventosUniversitarios.Participante> Participante { get; set; } = default!;

        public DbSet<EventosUniversitarios.Ponente> Ponente { get; set; } = default!;

        public DbSet<EventosUniversitarios.Reporte> Reporte { get; set; } = default!;

        public DbSet<EventosUniversitarios.Sesion> Sesion { get; set; } = default!;
    }
