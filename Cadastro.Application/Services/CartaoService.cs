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
    public class CartaoService : IPagamentoStrategy
    {
        public Result<PagamentoEntity> Pagar(PagamentoEntity pagamento)
        {

            // Lógica de pagar
            throw new NotImplementedException();
        }
    }
}
