namespace Y225012150.Models
{
    public class Roller
    {
        public int RollerID { get; set; }
        public string RoleAdi { get; set; }

        public ICollection<UserDetails>? UserDetails { get; set; }

    }
}
