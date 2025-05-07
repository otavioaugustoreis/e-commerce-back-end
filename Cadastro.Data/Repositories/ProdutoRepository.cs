using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositories
{
    public class ProdutoRepository : IRepository<ProdutoEntity>
    {
        public Task<ProdutoEntity> CreateAsync(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoEntity>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoEntity> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoEntity> RemoveAsync(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoEntity> UpdateAsync(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
