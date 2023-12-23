
using Microsoft.AspNetCore.Identity;

namespace Y225012150.Models
{
    public class UserDetails : IdentityUser
    {
        public string UserAd { get; set; }
        public string UserSoyad { get; set; }
    }
}


