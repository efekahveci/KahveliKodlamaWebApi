using Microsoft.AspNetCore.Identity;

namespace KahveliKodlama.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string Pass { get; set; }
   
    }
}
