using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Application.Services.Cache;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class ProdutoService
        (IUnitOfWork _unitOfWork) : IProdutoService
    {

        private readonly IUnitOfWork unitOfWork = _unitOfWork;
        //private readonly ICacheService cacheService = _cacheService;

        public async Task<Result<ProdutoEntity>> Insert(ProdutoEntity entity)
        {
            var produtoCadastrado = await unitOfWork.ProdutoRepository.CreateAsync(entity);
            unitOfWork.Commit();

            return Result<ProdutoEntity>.Success(produtoCadastrado, "Produto cadastrado com sucesso");
        }

        //public async Task<Result<IEnumerable<ProdutoEntity>>> Get()
        //{

        //    var products = await unitOfWork.ProdutoRepository.GetAsync();

        //    if (!products.Any())
        //    {
        //        return Result<IEnumerable<ProdutoEntity>>.Failure("Não existem produtos cadastrado");
        //    }

        //    return Result<IEnumerable<ProdutoEntity>>.Success(products);
        //}

        //public async Task<Result<ProdutoEntity>> GetId(int id)
        //{
        //    ProdutoEntity produto;

        //    var produtoCache = await cacheService.GetAsync(id.ToString());


        //    if (string.IsNullOrEmpty(produtoCache))
        //    {
        //        produto = await unitOfWork.ProdutoRepository.GetByIdAsync(id);

        //        if (produto is null)
        //        {
        //            return Result<ProdutoEntity>.Failure("O produto não foi encontrado");
        //        }
        //        await cacheService.SetAsync(produto.PkId.ToString(), JsonSerializer.Serialize(produto));

        //        return Result<ProdutoEntity>.Success(produto);
        //    }

        //    produto = JsonSerializer.Deserialize<ProdutoEntity>(produtoCache)!;
        //    return Result<ProdutoEntity>.Success(produto);
        //}

        public async Task<Result<ProdutoEntity>> Delete(int id)
        {
            var produto = await unitOfWork.ProdutoRepository.GetByIdAsync(id);

            if (produto is null)
                return Result<ProdutoEntity>.Failure("Produto não encontrado");

            var removerProduto = await unitOfWork.ProdutoRepository.RemoveAsync(produto);
            unitOfWork.Commit();

            return Result<ProdutoEntity>.Success(null, "Produto removido com sucesso");
        }


        public async Task<Result<IEnumerable<ProdutoEntity>>> GetAll()
        {

            var products = await unitOfWork.ProdutoRepository.GetAsync();

            if (!products.Any())
            {
                return Result<IEnumerable<ProdutoEntity>>.Failure("Não existem produtos cadastrado");
            }

            return Result<IEnumerable<ProdutoEntity>>.Success(products);
        }

        public async Task<Result<ProdutoEntity>> GetId(int? id)
        {
                ProdutoEntity produto;

                produto = await unitOfWork.ProdutoRepository.GetByIdAsync(id);

                if (produto is null)
                {
                    return Result<ProdutoEntity>.Failure("O produto não foi encontrado");
                }

            return Result<ProdutoEntity>.Success(produto);
        }

        public Task<Result<ProdutoEntity>> Create(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<Result<ProdutoEntity>> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
