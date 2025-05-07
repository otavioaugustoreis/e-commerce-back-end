using Cadastro.Application.Error;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Strategy
{
    public interface IPagamentoStrategy
    {
        Result<PagamentoEntity> Pagar(PagamentoEntity pagamento);
    }
}
