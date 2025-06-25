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
        (AppDbContext _appDbContext) : IUsuarioRepository
    {

        private readonly AppDbContext appDbContext = _appDbContext;

        public async Task<UsuarioEntity> CreateAsync(UsuarioEntity entity)
        {
             await appDbContext._Usuario.AddAsync(entity);
             return entity;
        }

        public async Task<IEnumerable<UsuarioEntity>> GetAsync()
        {
            return await appDbContext._Usuario.ToListAsync();
        }

        public async Task<UsuarioEntity> GetUsuarioByEmail(string email)
        {
            return await appDbContext._Usuario.FirstOrDefaultAsync(p => p.DsEmail.Trim().ToLower().Equals(email));
        }

        public async Task<UsuarioEntity> GetByIdAsync(int? id)
        {
            return await appDbContext._Usuario.FirstOrDefaultAsync(p => p.PkId == id);
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
