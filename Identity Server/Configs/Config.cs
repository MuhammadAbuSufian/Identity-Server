using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;

namespace Identity_Server.Configs
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client()
                {
                    ClientId = "movieClient",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "movieAPI" }
                }
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("movieAPI", "Movie API")
            };

        public static IEnumerable<TestUser> TestUsers =>
            new TestUser[]
            {
                new TestUser()
            };
    }
}
