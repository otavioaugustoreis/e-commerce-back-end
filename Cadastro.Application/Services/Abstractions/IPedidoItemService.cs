using Cadastro.Application.Return;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Abstractions
{
    public interface IPedidoItemService 
    {
        Task<Result<PedidoItemEntity>> Criar(ProdutoEntity produtoEntity, PagamentoEntity pagamentoEntity);

    }
}
