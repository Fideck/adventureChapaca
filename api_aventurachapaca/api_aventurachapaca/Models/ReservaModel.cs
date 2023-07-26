using System.ComponentModel.DataAnnotations;

namespace api_aventurachapaca.Models
{
    public class ReservaModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public DateTime fecha { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public int estado { get; set; }

        public int TourId { get; set; }
        public TourModel tour { get; set; }

        public int UserId { get; set; }
        public UserModel user { get; set; }

    }
}
