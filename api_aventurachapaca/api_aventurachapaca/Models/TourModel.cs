using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace api_aventurachapaca.Models
{
    public class TourModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public int precio { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public int duracion { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string adicionales { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string recomendaciones { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public int estado { get; set; }

        public int PersonId { get; set; }
        public PersonModel person { get; set; }

        public List<PagoModel> Pago { get; set; }
    }
}
