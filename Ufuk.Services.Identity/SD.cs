using Duende.IdentityServer.Models;

namespace Ufuk.Services.Identity
{
    public class SD // 131st step.
    {
        // 132nd step.
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        // 133rd step.
        public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Email(),
            new IdentityResources.Profile()
        };
    }
}
