using Cadastro.Application.Services.Strategy;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Factory
{
    public interface IPagamentoFactory
    {
        IPagamentoStrategy RetornarPagamento(TipoPagamento pagamentoEntity);
    }
}
