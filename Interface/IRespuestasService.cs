using ExamenFinalWeb.Models;

namespace ExamenFinalWeb.Interface
{
    public interface IRespuestasService
    {
        Task<Respuestas> CreateAsync(Respuestas r);
        Task<Respuestas> GetByIdAsync(int id);
    }
}
