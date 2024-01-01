namespace Y225012150.Models
{
    public class Klinik
    {
        public int KlinikID { get; set; }
        public int IlceID { get; set; }
        public Ilce Ilce { get; set; }
        public string KlinikAdi { get; set; }
    }
}
