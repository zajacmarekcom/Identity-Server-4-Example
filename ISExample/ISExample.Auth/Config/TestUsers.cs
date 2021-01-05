using IdentityModel;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ISExample.Auth.Config
{
    public class TestUsers
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "testuser",
                    Password = "password1",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email, "testuser@testing.com"),
                        new Claim(JwtClaimTypes.Role, "employee")
                    }
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "customer",
                    Password = "password1",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email, "customer@foo.com"),
                        new Claim(JwtClaimTypes.Role, "customer")
                    }
                }
            };
        }
    }
}
