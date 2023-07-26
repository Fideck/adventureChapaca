using System.ComponentModel.DataAnnotations;

namespace api_aventurachapaca.Models
{
    public class ComentariosModel
    {
        [Key]
        public int Id { get; set; }
        public string descripcion { get; set; }
        public DateTime fehca { get; set; }
        public byte estado { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}
