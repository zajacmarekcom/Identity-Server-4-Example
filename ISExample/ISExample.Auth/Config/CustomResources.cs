using IdentityServer4.Models;
using System.Collections.Generic;

namespace ISExample.Auth.Config
{
    public class CustomResources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource
                {
                    Name = "role",
                    UserClaims = new List<string> { "role" }
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                new ApiResource
                {
                    Name = "invoices",
                    DisplayName = "Invoices",
                    Description = "Invoices",
                    Scopes = new List<string> { "invoices.read", "invoices.write" },
                    ApiSecrets = new List<Secret> { new Secret("7jGF!*k:|_GQ9J=xDfb%V4Eqz.^ULTsFC#]`y&K7U`#}>k)^)bGZ:EumnFBdI".Sha256())},
                    UserClaims = new List<string> { "role" }
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
                new ApiScope("invoices.read", "Read"),
                new ApiScope("invoices.write", "Write")
            };
        }
    }
}
