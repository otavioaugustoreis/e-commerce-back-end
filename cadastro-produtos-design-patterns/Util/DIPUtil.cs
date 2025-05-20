using Cadastro.Application.Services;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Data.Repositories;
using Cadastro.Data.Repositories.Pattern;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
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
            builder.AddScoped<IPedidoItemService, PedidoItemService>();
            builder.AddScoped<IRepository<PedidoItemEntity>,PedidoItemRepository>();

            return builder;
        }
    }
}
