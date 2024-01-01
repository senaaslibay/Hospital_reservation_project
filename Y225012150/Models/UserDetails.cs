
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Y225012150.Models
{
    public class UserDetails : IdentityUser
    {
        public string UserAd { get; set; }
        public string UserSoyad { get; set; }
        public int RollerID { get; set; }
        public Roller Roller { get; set; }
        public ICollection<Randevu>? Randevular { get; set; }

    }
}


