namespace api_aventurachapaca.Models
{
    public class Tour_LugarModel
    {
        public int Id { get; set; }

        public int TourId { get; set; }
        public TourModel Tour { get; set; }

        public int LugarId { get; set; }
        public LugarModel Lugar { get; set; }
    }
}
