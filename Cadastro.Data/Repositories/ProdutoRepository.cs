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
    public class ProdutoRepository
        (AppDbContext _appDbContext) : IRepository<ProdutoEntity>
    {

        private readonly AppDbContext appDbContext = _appDbContext;

        public async Task<ProdutoEntity> CreateAsync(ProdutoEntity entity)
        {
            appDbContext.Add(entity);
            return entity;
        }

        public async Task<IEnumerable<ProdutoEntity>> GetAsync()
        {
            return await appDbContext._Produto.ToListAsync();
        }

        public async Task<ProdutoEntity> GetByIdAsync(int? id)
        {
            var produto = appDbContext._Produto.FirstOrDefault(p => p.PkId == id);

            return produto;
        }

        public Task<ProdutoEntity> RemoveAsync(ProdutoEntity entity)
        {
            appDbContext.Remove(entity);

            return Task.FromResult(entity);
        }

        public async Task<ProdutoEntity> UpdateAsync(ProdutoEntity entity)
        {
            appDbContext.Update(entity);
            return entity;
        }
    }
}
