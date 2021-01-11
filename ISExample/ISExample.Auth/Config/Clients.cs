using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISExample.Auth.Config
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "testClient",
                    ClientName = "Test Client",
                    AllowOfflineAccess = true,
                    RedirectUris = new List<string> { "http://localhost:4200/assets/callback.html" },
                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequireClientSecret = false,
                    AllowAccessTokensViaBrowser = true,
                    //ClientSecrets = new List<Secret> { new Secret("bvne(BW0{eGZU#rhS$OYRG_Mk[:m*$Ev`BL)V2h>;H6wRWY~=1f3r|G>Z9bMxeH".Sha256()) },
                    AllowedScopes = new List<string> {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "invoices",
                        "invoices.read",
                        "invoices.write" }
                }
            };
        }
    }
}
