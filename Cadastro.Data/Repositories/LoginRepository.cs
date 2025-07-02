using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositories
{
    public class LoginRepository(AppDbContext _appDbContext) 
        : IRepository<LoginEntity>
    {
        private readonly AppDbContext appDbContext = _appDbContext;


        public async Task<LoginEntity> CreateAsync(LoginEntity entity)
        {
            appDbContext.Add(entity);
            return entity;
        }

        public async Task<IEnumerable<LoginEntity>> GetAsync()
        {
            return appDbContext._Login.ToList();
        }

        public async Task<LoginEntity> GetByIdAsync(int? id)
        {
            return appDbContext._Login.FirstOrDefault(p => p.PkId == id);
        }

        public async Task<LoginEntity> RemoveAsync(LoginEntity entity)
        {
            appDbContext.Remove(entity);
            return entity;
        }

        public async Task<LoginEntity> UpdateAsync(LoginEntity entity)
        {
            appDbContext.Update(entity);
            return entity;
        }
    }
}
