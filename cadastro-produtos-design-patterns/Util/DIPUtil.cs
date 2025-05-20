using Cadastro.Application.Services;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Data.UnitOfWork;
using Microsoft.AspNetCore.WebSockets;
using System.Runtime.CompilerServices;

namespace cadastro_produtos_design_patterns.Util
{
    public static class DIPUtil 
    {
        public static IServiceCollection AddDIP(this IServiceCollection builder)
        {
            builder.AddScoped<IUsuarioService, UsuarioService>();
            builder.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.AddScoped<IProdutoService, ProdutoService>();
            builder.AddScoped<IPedidoItemService, PedidoIte>();


            return builder;
        }
    }
}
