using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace api_aventurachapaca.Models
{
    public class ReservaModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacío")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacío")]

        public string precio { get; set; }
        public int estado { get; set; }

        public int UserId { get; set; }
        public UserModel User { get; set; }

        public List<PagoModel> Pago { get; set; }
    }
}
