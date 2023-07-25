using System.ComponentModel.DataAnnotations;

namespace api_aventurachapaca.Models
{
    public class PagoModel
    {
        [Key]
        public int idPago { get; set; }
        public int cantidad { get; set; }
        public string codigo { get; set; }
        public byte estado { get; set; }
        public int precio { get; set; }
        public int ReservaId { get; set; }
        public ReservaModel reserva { get; set; }
        public DateTime fecha { get; set;}
    }
}
