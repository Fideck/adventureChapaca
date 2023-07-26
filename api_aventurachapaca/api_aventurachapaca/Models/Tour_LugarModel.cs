namespace api_aventurachapaca.Models
{
    public class Tour_LugarModel
    {
        public int id { get; set; }

        public int TourId { get; set; }
        public TourModel tour { get; set; }

        public int lugarId { get; set; }
        public LugarModel lugar { get; set; }
    }
}
