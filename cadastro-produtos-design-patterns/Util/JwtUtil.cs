using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Runtime.CompilerServices;
using System.Text;

namespace cadastro_produtos_design_patterns.Util
{
    public static class JwtUtil
    {

        public static IServiceCollection AddJwtConfiguration(this IServiceCollection service)
        {
            var key = Encoding.ASCII.GetBytes(Environment.GetEnvironmentVariable("KEY")
                           ?? throw new ArgumentException("Invalid secret key!!"));

            service.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false, // ou true, se quiser validar o issuer
                    ValidateAudience = false, // ou true, se quiser validar o audience
                    ClockSkew = TimeSpan.Zero
                };
            });

            service.AddAuthentication();

            return service;
        }
    }
}
