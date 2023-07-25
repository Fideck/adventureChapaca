using System.ComponentModel.DataAnnotations;

namespace api_aventurachapaca.Models
{
    public class LugarModel
    {
        [Key]
        public int Id { get; set; }
        public string nombre { get; set; }
        public string Descripcion { get; set; }
        public string ubicacion { get; set; }
        public byte estado { get; set; }

        public int IMG_LUGARId { get; set; }
        public IMG_LUGARModel imagen { get; set; }
    }
}
