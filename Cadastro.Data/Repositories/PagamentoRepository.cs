using Cadastro.Data.Data;
using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositories
{
    public class PagamentoRepository
        (AppDbContext _appDbContext) : IRepository<PagamentoEntity>
    {

        private readonly AppDbContext appDbContext = _appDbContext;

        public async Task<PagamentoEntity> CreateAsync(PagamentoEntity entity)
        {
            appDbContext.Add(entity);
            return entity;
        }

        public async Task<IEnumerable<PagamentoEntity>> GetAsync()
        {
            return appDbContext._Pagamento.ToList();
        }

        public async Task<PagamentoEntity> GetByIdAsync(int? id)
        {
            return appDbContext._Pagamento.FirstOrDefault(p => p.PkId == id);
        }

        public async Task<PagamentoEntity> RemoveAsync(PagamentoEntity entity)
        {
            appDbContext.Remove(entity);
            return entity;
        }

        public async Task<PagamentoEntity> UpdateAsync(PagamentoEntity entity)
        {
            appDbContext.Update(entity);
            return entity;
        }
    }
}
