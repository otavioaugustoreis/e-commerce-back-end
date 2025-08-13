using Cadastro.Application.Services;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Application.Services.Cache;
using Cadastro.Application.Services.Composite;
using Cadastro.Application.Services.Factory;
using Cadastro.Application.Services.Strategy;
using Cadastro.Application.Services.Token;
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
            builder.AddScoped<IRepository<PedidoItemEntity>, PedidoItemRepository>();
            builder.AddScoped<IRepository<PedidoEntity>, PedidoRepository>();
            builder.AddScoped<IRepository<NotificacaoEntity>, NotificacaoRepository>();
            builder.AddScoped<IRepository<PagamentoEntity>, PagamentoRepository>();
            builder.AddScoped<IRepository<ProdutoEntity>, ProdutoRepository>();
            builder.AddScoped<IUsuarioRepository, UsuarioRepository>();
            builder.AddScoped<ILoginRepository, LoginRepository>();

            builder.AddScoped<IUsuarioService, UsuarioService>();
            builder.AddScoped<IProdutoService, ProdutoService>();
            builder.AddScoped<IPedidoItemService, PedidoItemService>();
            builder.AddScoped<IPagamentoService, PagamentoService>();
            builder.AddScoped<IPedidoService, PedidoService>();
            builder.AddScoped<INotificacaoService, NotificacaoServiceComposite>();
            builder.AddScoped<ILoginService, LoginService>();
            builder.AddScoped<ITokenService, TokenService>();

            builder.AddScoped<IPagamentoStrategy, CartaoStrategy>();
            builder.AddScoped<IPagamentoStrategy, PixStrategy>();

            builder.AddScoped<IPagamentoFactory, PagamentoFactory>();

            builder.AddScoped<IUnitOfWork, UnitOfWork>();
            //  builder.AddScoped<ICacheService, CachingService>();


            return builder;
        }
    }
}
