using System.ComponentModel.DataAnnotations;

namespace api_aventurachapaca.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string usuario { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string contrasenia { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string correo { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public int tipousuario { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public int estado { get; set; }

        public int PersonId { get; set; }
        public PersonModel Person { get; set; }
    }
}
