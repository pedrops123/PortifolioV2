using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using webApi.Models;

namespace webApi.Services {
    public class TokenService {

        private static string hashServer = "";
        public TokenService(IConfiguration configuration) {
            hashServer = configuration.GetSection("hashServer").Value;
        }

        public string GenerateToken(LoginFormModel modelUsuario , string roles){

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(hashServer);
            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[]{
                        new Claim(ClaimTypes.Name,modelUsuario.login),
                        new Claim(ClaimTypes.Role, roles)
 
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };
           var token = tokenHandler.CreateToken(tokenDescriptor);
           return tokenHandler.WriteToken(token);
        }

    }

}