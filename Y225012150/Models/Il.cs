using System.Drawing;

namespace Y225012150.Models
{
    public class Il
    {
        public int IlID { get; set; }
        public string IlAdi { get; set; }
        public ICollection<Ilce>? Ilceler { get; set; }

    }
}
