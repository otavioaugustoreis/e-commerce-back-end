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
    public class PagamentoService 
        (IPagamentoFactory _pagamentoFactory,
        IUnitOfWork _unitOfWork, 
        IMediator mediator,
        IPedidoService _pedidoService) : IPagamentoService
    {
        private readonly IPagamentoFactory pagamentoFactory = _pagamentoFactory;
        private readonly IUnitOfWork unitOfWork = _unitOfWork;
        private readonly IMediator _mediator = mediator;
        private readonly IPedidoService pedidoService = _pedidoService;  

        public async Task<Result<PagamentoEntity>> Insert(PagamentoEntity pagamento)
        {
            IPagamentoStrategy result = pagamentoFactory.RetornarPagamento(pagamento.TipoPagamento);
           
            var pagando = result.Pagar(pagamento);

             unitOfWork!.PagamentoRepository!.CreateAsync(pagando.Value!);

            await _mediator.Publish(new PagamentoAprovadoEvent(pagando.Value.PkId, pagando.Value.Valor));

            return pagando;
        }

        public Task<Result<PagamentoEntity>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<PagamentoEntity>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Result<PagamentoEntity>> GetId(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<PagamentoEntity>> GetPagamentoByPedidoById(int idPedido)
        {
            throw new NotImplementedException();
        }


        public Task<Result<PagamentoEntity>> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
