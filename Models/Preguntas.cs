using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenFinalWeb.Models
{
    public class Preguntas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPregunta { get; set; }
        public string enunciado { get; set; }
        public string categoria {  get; set; }
        public int fueResuelta { get; set; } = 0;
    }
}
