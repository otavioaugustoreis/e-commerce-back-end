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
    public class UsuarioRepository
        (AppDbContext _appDbContext) : IRepository<UsuarioEntity>
    {

        private readonly AppDbContext appDbContext = _appDbContext;

        public async Task<UsuarioEntity> CreateAsync(UsuarioEntity entity)
        {
             appDbContext._Usuario.Add(entity);
             return entity;
        }

        public async Task<IEnumerable<UsuarioEntity>> GetAsync()
        {
            return await appDbContext._Usuario.ToListAsync();
        }

        public async Task<UsuarioEntity> GetByIdAsync(int? id)
        {
            var usuario =  appDbContext._Usuario.FirstOrDefault(p => p.PkId == id);

            return  usuario;
        }
        public async Task<UsuarioEntity> RemoveAsync(UsuarioEntity entity)
        {

             appDbContext._Usuario.Remove(entity);
            return entity;
        }

        public async Task<UsuarioEntity> UpdateAsync(UsuarioEntity entity)
        {
           appDbContext.Update(entity);
            return entity;
        }
    }
}
