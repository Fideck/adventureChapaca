using System.ComponentModel.DataAnnotations;

namespace api_aventurachapaca.Models
{
    public class IMG_LUGARModel
    {
        [Key]
        public int id { get; set; }
        public string imagen { get; set; }
        public byte estado { get; set; }
    }
}
