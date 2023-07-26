using System.ComponentModel.DataAnnotations;

namespace api_aventurachapaca.Models
{
    public class Comentario_TourModel
    {
        [Key]
        public int Id { get; set; }
        public int ComentariosId { get; set; }
        public ComentariosModel Comentarios { get; set; }
        public int TourId { get; set; }
        public TourModel Tour { get; set; }
    }
}
