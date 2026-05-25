using Microsoft.EntityFrameworkCore;
using ExamenFinalWeb.Models;

namespace ExamenFinalWeb.DAO
{
    public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<Preguntas> Pregunta { get; set; }
            public DbSet<Respuestas> Respuesta { get; set; }
    }
}

