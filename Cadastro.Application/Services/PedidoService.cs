using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class PedidoService
        (IUnitOfWork _unitOfWork) : IPedidoService
    {
        private readonly IUnitOfWork unitOfWork = _unitOfWork;

        public Task<Result<PedidoEntity>> Criar(PedidoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<Result<PedidoEntity>> CriarComPagamento(PagamentoEntity pagamentoEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<PedidoEntity>>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Result<PedidoEntity>> GetId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
