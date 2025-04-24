using Cadastro.Data.Data;
using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositories
{
    public class PagamentoRepository : IRepository<PagamentoEntity>
    {

        private readonly AppDbContext appDbContext;

        public PagamentoRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Task<PagamentoEntity> CreateAsync(PagamentoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PagamentoEntity>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PagamentoEntity> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<PagamentoEntity> RemoveAsync(PagamentoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<PagamentoEntity> UpdateAsync(PagamentoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
