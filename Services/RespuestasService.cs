using ExamenFinalWeb.DAO;
using ExamenFinalWeb.Interface;
using ExamenFinalWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenFinalWeb.Services
{
    public class RespuestasService : IRespuestasService
    {
        private readonly AppDbContext _context;

        public RespuestasService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Respuestas> CreateAsync(Respuestas r)
        {
            _context.Respuesta.Add(r);
            await _context.SaveChangesAsync();
            return r;
        }
    }

}
