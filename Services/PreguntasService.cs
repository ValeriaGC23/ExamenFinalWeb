using ExamenFinalWeb.DAO;
using ExamenFinalWeb.Interface;
using ExamenFinalWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenFinalWeb.Services
{
    public class PreguntasService : IPreguntasService
    {
        private readonly AppDbContext _context;

        public PreguntasService(AppDbContext context)
        {
            _context = context;
        }

        private async Task<int> ChangeStatusAsync(int id)
        {
            var objExist = await _context.Pregunta.FindAsync(id);
            if (objExist == null) return -1;

            objExist.fueResuelta = objExist.fueResuelta == 0 ? 1 : 0;

            await _context.SaveChangesAsync();
            return objExist.fueResuelta;
        }

        public async Task<Preguntas> CreateAsync(Preguntas p)
        {
            _context.Pregunta.Add(p);
            await _context.SaveChangesAsync();
            return p;
        }

        public async Task<Preguntas?> GetByIdAsync(int id)
        {
            return await _context.Pregunta.FindAsync(id);
        }

        public async Task<List<Preguntas>> GetNoResueltasAsync()
        {
            return await _context.Pregunta.Where(e => e.fueResuelta == 0).ToListAsync();
        }

        public async Task<List<Preguntas>> GetResueltasAsync()
        {
            return await _context.Pregunta.Where(e => e.fueResuelta == 1).ToListAsync();
        }
    }
}
