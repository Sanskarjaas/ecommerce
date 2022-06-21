using ecommerce_app.Controllers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce_app
{
    public class AuthenticateService : IAuthenticateService

    {
        private readonly IDictionary<string, string> users = new Dictionary<string, string>
        { { "test1","password"},{"test2","password2" } };
        private readonly string key;

        public AuthenticateService(string key)
        {
            this.key = key;      
        }
        public string Authenticate(string username, string password)
        {
            if(!users.Any(u=>u.Key==username && u.Value ==password))
            {
                return null;

            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);
            var tokenDescriptior = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name,username)
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature)


            };
            var token = tokenHandler.CreateToken(tokenDescriptior);
            return tokenHandler.WriteToken(token);
        }
    }
}
