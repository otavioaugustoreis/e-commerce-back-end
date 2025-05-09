using Cadastro.Application.Return;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Strategy
{
    public class PixStrategy : IPagamentoStrategy
    {
        public Result<PagamentoEntity> Pagar(PagamentoEntity pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
