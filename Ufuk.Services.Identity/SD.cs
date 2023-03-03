using Duende.IdentityServer.Models;

namespace Ufuk.Services.Identity
{
    public class SD // 131st step.
    {
        // 132nd step.
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        // 133rd step.
        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };

        // 134th step.
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("Ufuk", "Ufuk Server"),
                new ApiScope(name: "read", displayName: "Read your data."),
                new ApiScope(name: "write", displayName: "Write your data."),
                new ApiScope(name: "delete", displayName: "Delete your data.")
            };
    }
}
