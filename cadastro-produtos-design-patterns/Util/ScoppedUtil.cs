using Cadastro.Application.Services;
using Cadastro.Data.UnitOfWork;
using Microsoft.AspNetCore.WebSockets;
using System.Runtime.CompilerServices;

namespace cadastro_produtos_design_patterns.Util
{
    public static class ScoppedUtil 
    {
        public static IServiceCollection AddDIP(this IServiceCollection builder)
        {
            builder.AddScoped<IUsuarioService, UsuarioService>();
            builder.AddScoped<IUnitOfWork, UnitOfWork>();

            return builder;
        }
    }
}
