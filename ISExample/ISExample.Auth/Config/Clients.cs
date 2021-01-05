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
                    RedirectUris = new List<string> { "http://localhost:4200" },
                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    RequireClientSecret = false,
                    //ClientSecrets = new List<Secret> { new Secret("bvne(BW0{eGZU#rhS$OYRG_Mk[:m*$Ev`BL)V2h>;H6wRWY~=1f3r|G>Z9bMxeH".Sha256()) },
                    AllowedScopes = new List<string> { "invoices.write", "invoices.read" }
                }
            };
        }
    }
}
