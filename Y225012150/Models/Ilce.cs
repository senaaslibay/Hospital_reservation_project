namespace Y225012150.Models
{
    public class Ilce
    {
        public int IlceID { get; set; }
        public int IlID { get; set; }
        public Il Il { get; set; }
        public string IlceAdi { get; set; }
        public ICollection<Klinik>? Klinikler { get; set; }

    }
}
