using Cadastro.Application.Services.Strategy;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Factory
{
    public class PagamentoFactory : IPagamentoFactory
    {
        private readonly IServiceProvider services;
        public IPagamentoStrategy RetornarPagamento(TipoPagamento tipoPagamento)
        {
            return tipoPagamento switch
            {
                TipoPagamento.CARTAO => services.GetRequiredService<CartaoService>(),
                TipoPagamento.PIX => services.GetRequiredService<PixService>(),
                _ => throw new NotImplementedException("Tipo não implementado.")

            };
        }
    }
}
