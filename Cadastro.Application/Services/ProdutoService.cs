using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class ProdutoService
        (IUnitOfWork _unitOfWork) : IProdutoService
    {

        private readonly IUnitOfWork unitOfWork = _unitOfWork;

        public async Task<Result<ProdutoEntity>> Criar(ProdutoEntity entity)
        {
            var produtoCadastrado = await unitOfWork.ProdutoRepository.CreateAsync(entity);
            unitOfWork.Commit();

            return Result<ProdutoEntity>.Success(produtoCadastrado, "Produto cadastrado com sucesso");
        }

        public async  Task<Result<IEnumerable<ProdutoEntity>>> Get()
        {

            var products = await unitOfWork.ProdutoRepository.GetAsync();

            if (!products.Any())
            {
            return Result<IEnumerable<ProdutoEntity>>.Failure("Não existem produtos cadastrado");
            }
            
            return Result<IEnumerable<ProdutoEntity>>.Success(products);
        }

        public async Task<Result<ProdutoEntity>> GetId(int id)
        {

            var produto = unitOfWork.ProdutoRepository.GetByIdAsync(id);

            if(produto is null)
            {
                return Result<ProdutoEntity>.Failure("O produto não foi encontrado");
            }

            return Result<ProdutoEntity>.Success(produto.Result);
        }

        public async Task<Result<ProdutoEntity>> Deletar(int id)
        {
            var produto =  await unitOfWork.ProdutoRepository.GetByIdAsync(id);

            if(produto is null)
                return Result<ProdutoEntity>.Failure("Produto não encontrado");

            var removerProduto = await unitOfWork.ProdutoRepository.RemoveAsync(produto);
            unitOfWork.Commit();

            return Result<ProdutoEntity>.Success(null, "Produto removido com sucesso");
        }

    }
}
