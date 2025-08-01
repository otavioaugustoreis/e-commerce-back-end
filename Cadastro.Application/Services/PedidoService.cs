﻿using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Enums;
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

        public async Task<Result<PedidoEntity>> Criar(PedidoEntity entity)
        {
            var valorPedido = await CalcularValorPedidoAsync(entity.PedidoItemEntity);

            if (!valorPedido.IsSuccess) 
            { 
                return Result<PedidoEntity>.Failure(valorPedido.ErrorMessage);
            }

            entity.Status = PedidoStatus.PENDENTE;
            entity.NrValor = valorPedido.Value;

            await unitOfWork.PedidoRepository.CreateAsync(entity);

            return Result<PedidoEntity>.Success(entity);
        }

        public Task<Result<PedidoEntity>> CriarComPagamento(PagamentoEntity pagamentoEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Result<PedidoEntity>> Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<PedidoEntity>>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Result<PedidoEntity>> GetId(int id)
        {
            throw new NotImplementedException();
        }

        private async void CriarPedidoItemAsync(List<PedidoItemEntity> pedidoItemEntity, int idPedido)
        {
            foreach (var item in pedidoItemEntity) 
            {
                await unitOfWork.PedidoItemRepository.CreateAsync(item);
                unitOfWork.Commit();
            }
        }

        private async Task<Result<double>> CalcularValorPedidoAsync(List<PedidoItemEntity> pedidoItemEntity)
        {
            double valor = 0;

            foreach (var item in pedidoItemEntity) 
            {
                var produto = await unitOfWork.ProdutoRepository.GetByIdAsync(item.FkProduto);

                if (item.NrQuantidade > produto.Quantidade)
                {
                    return Result<double>.Failure("A quantidade fornecida não corresponde com a quantidade do produto");
                }
                
                var valorProduto = produto.NrValor;
                var quantidade = item.NrQuantidade;

                valor += valorProduto * quantidade;

                produto.DiminuirQuantidade(quantidade);

                await unitOfWork.ProdutoRepository.UpdateAsync(produto);
                unitOfWork.Commit();
            }

            return Result<double>.Success(valor);
        }
    }
}
