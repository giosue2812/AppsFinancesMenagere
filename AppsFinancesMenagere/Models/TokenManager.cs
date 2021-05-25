using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AppsFinancesMenagere.Models
{
    public class TokenManager
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        private readonly IConfiguration _config;
        public TokenManager(IConfiguration config)
        {
            _config = config;
            Secret = _config.GetValue<string>("Token:Secret");
            Issuer = _config.GetValue<string>("Token:Issuer");
            Audience = _config.GetValue<string>("Token:Audience");
        }
        public string GenerateJwt(UserAuth user)
        {
            if (user.Email is null) throw new ArgumentNullException();
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("Id", user.IdUser.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim("IdAccount", user.IdAccount.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Issuer = Issuer,
                Audience = Audience,
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials
            };
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
