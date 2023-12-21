using System.ComponentModel.DataAnnotations;

namespace Y225012150.Models
{
    public class Alanlar
    {
        [Key]
        public int AlanId { get; set; }
        [Required]
        [Display(Name = "Alanı ")]
        public string AlanAdi { get; set; }
    }
}
