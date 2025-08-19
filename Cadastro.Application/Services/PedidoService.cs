using Cadastro.Application.Return;
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

        public async Task<Result<PedidoEntity>> Insert(PedidoEntity entity)
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

        public Task<Result<PedidoEntity>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<PedidoEntity>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Result<PedidoEntity>> GetId(int? id)
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



            return Result<double>.Success(valor);
        }


        public Task<Result<PedidoEntity>> Update(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<PedidoEntity>> PedidoPago(PedidoEntity pedidoEntity, PagamentoEntity pagamentoEntity)
        {
            throw new NotImplementedException();
        }
    }
}
