using Cadastro.Application.Services.Abstractions;
using Cadastro.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Token
{
    public class TokenService : ITokenService
    {
        public string Generate(UsuarioEntityToken usuarioEntity)
        {
            var handler = new JwtSecurityTokenHandler();


            var key = Encoding.ASCII.GetBytes(Environment.GetEnvironmentVariable("KEY") 
                            ?? throw new ArgumentException("Invalid secret key!!"));

            var credentials = new SigningCredentials(
                  new SymmetricSecurityKey(key)
                , SecurityAlgorithms.HmacSha256Signature);


            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = GenerateClaims(usuarioEntity),
                SigningCredentials = credentials,
                Expires = DateTime.Now.AddHours(2)
            };


            var token = handler.CreateToken(tokenDescriptor);

            var stringToken = handler.WriteToken(token);

            return stringToken;
        }
    
        private static ClaimsIdentity GenerateClaims(UsuarioEntityToken usuario)
        {
            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.Name, usuario.DsNome));

            foreach(var role in usuario.Roles)
            {
                claims.AddClaim(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }
    }
}
