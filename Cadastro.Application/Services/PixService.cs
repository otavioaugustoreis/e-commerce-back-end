using Cadastro.Application.Error;
using Cadastro.Application.Services.Strategy;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class PixService : IPagamentoStrategy
    {
        public Result<PagamentoEntity> Pagar(PagamentoEntity pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
