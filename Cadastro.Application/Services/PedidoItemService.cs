using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Data.Repositories;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class PedidoItemService
        (IUnitOfWork _unitOfWork) : IPedidoItemService
    {

        private readonly IUnitOfWork unitOfWork = _unitOfWork;

        public Task<Result<PedidoItemEntity>> Criar(ProdutoEntity produtoEntity, PagamentoEntity pagamentoEntity)
        {
            return null;
        }
    }
}
