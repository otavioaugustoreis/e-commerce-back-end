using Cadastro.Application.Return;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Abstractions
{
    public interface IPedidoService : IService<PedidoEntity>
    {
        Task<Result<PedidoEntity>> CriarComPagamento(PagamentoEntity pagamentoEntity);
        Task<Result<ProdutoEntity>> CalcularValorPedido(PagamentoEntity pagamentoEntity);
    }
}
