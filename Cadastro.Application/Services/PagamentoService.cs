using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Application.Services.Event;
using Cadastro.Application.Services.Factory;
using Cadastro.Application.Services.Strategy;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoFactory pagamentoFactory;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator _mediator;

        public PagamentoService(IPagamentoFactory pagamentoFactory, IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.pagamentoFactory = pagamentoFactory;
            this.unitOfWork = unitOfWork;
            this._mediator = mediator;
        }

        public async  Task<Result<PagamentoEntity>> Pagar(PagamentoEntity pagamento)
        {

            IPagamentoStrategy result = pagamentoFactory.RetornarPagamento(pagamento.TipoPagamento);
            var pagando = result.Pagar(pagamento);

            unitOfWork!.PagamentoRepository!.CreateAsync(pagando.Value!);

            await _mediator.Publish(new PagamentoAprovadoEvent(pagando.Value.PkId, pagando.Value.Valor));

            return pagando;
        }
    }
}
