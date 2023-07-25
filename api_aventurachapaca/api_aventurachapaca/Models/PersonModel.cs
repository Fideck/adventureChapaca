using System.ComponentModel.DataAnnotations;

namespace api_aventurachapaca.Models
{
    public class PersonModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string tipodocumentp { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string documento { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string apeliido { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public int genero { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public DateTime fechanac { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string telefono { get; set; }
    }
}
