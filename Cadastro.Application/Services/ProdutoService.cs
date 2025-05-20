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
    public class ProdutoService
        (IUnitOfWork _unitOfWork) : IProdutoService
    {

        private readonly IUnitOfWork unitOfWork = _unitOfWork;

        public Task<Result<ProdutoEntity>> Criar(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<ProdutoEntity>>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Result<ProdutoEntity>> GetId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
