#nullable disable
using Microsoft.AspNetCore.Identity;

namespace ReactAspNetCoreIdentity.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
