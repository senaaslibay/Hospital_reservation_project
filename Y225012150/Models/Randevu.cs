
using System.ComponentModel.DataAnnotations;

namespace Y225012150.Models
{
    public class Randevu
    {
        [Key]
        public int RandevuId { get; set; }
        [Required]
        [Display(Name = "İl")]
        public string RandevuIl { get; set; }
        [Required]
        [Display(Name = "İlçe")]
        public string RandevuIlce { get; set; }
        [Required]
        [Display(Name = "Klinik")]
        public string RandevuKlinik { get; set; }
        [Required]
        [Display(Name = "Hastane")]
        public string RandevuHastane { get; set; }
        [Required]
        [Display(Name = "Muayene Yeri")]
        public string RandevuMuayeneYeri { get; set; }
        [Required]
        [Display(Name = "Hekim")]
        public string RandevuHekim { get; set; }
        [Required]
        [Display(Name = "Tarih")]
        public DateTime RandevuTarih { get; set; }
    }
}
