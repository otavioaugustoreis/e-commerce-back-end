using Cadastro.Application.Error;
using Cadastro.Application.Services.Factory;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class PagamentoService 
    {

        private readonly IPagamentoFactory pagamentoFactory;
        private readonly IUnitOfWork unitOfWork;

        public async  Task<Result<PagamentoEntity>> Pagar(PagamentoEntity pagamento)
        {
            
            var result = pagamentoFactory.RetornarPagamento(pagamento.TipoPagamento);
            var pagando = result.Pagar(pagamento);

            unitOfWork.PagamentoRepository.CreateAsync(pagando.Value);

            return pagando;
        }


    }
}
