using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenFinalWeb.Models
{
    public class Respuestas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idRespuesta {  get; set; }
        public string contenido { get; set; }

        public int idPregunta { get; set; }

        public DateTime fechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
