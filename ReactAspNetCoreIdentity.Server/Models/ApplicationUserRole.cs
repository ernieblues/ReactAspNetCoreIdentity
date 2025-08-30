#nullable disable
using Microsoft.AspNetCore.Identity;

namespace ReactAspNetCoreIdentity.Server.Models
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
