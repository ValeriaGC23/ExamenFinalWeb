using ExamenFinalWeb.Models;

namespace ExamenFinalWeb.Interface
{
    public interface IPreguntasService
    {
        Task<List<Preguntas>> GetResueltasAsync();
        Task<List<Preguntas>> GetNoResueltasAsync();
        Task<Preguntas?> GetByIdAsync(int id);
        Task<Preguntas> CreateAsync(Preguntas p);
    }
}
