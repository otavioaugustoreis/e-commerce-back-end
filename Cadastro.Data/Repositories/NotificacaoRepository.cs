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
    public class NotificacaoRepository
        (AppDbContext _appDbContext) : IRepository<NotificacaoEntity>
    {

        private readonly AppDbContext appDbContext = _appDbContext;


        public async Task<NotificacaoEntity> CreateAsync(NotificacaoEntity entity)
        {
            appDbContext.Add(entity);
            return entity;
        }

        public async Task<IEnumerable<NotificacaoEntity>> GetAsync()
        {
            return await appDbContext._Notificacao.ToListAsync();
        }

        public async Task<NotificacaoEntity> GetByIdAsync(int? id)
        {
            var entity = appDbContext._Notificacao.FirstOrDefault(p => p.PkId == id);
            return entity;
        }

        public async Task<NotificacaoEntity> RemoveAsync(NotificacaoEntity entity)
        {
            appDbContext.Remove(entity);
            return entity;
        }

        public async Task<NotificacaoEntity> UpdateAsync(NotificacaoEntity entity)
        {
            appDbContext.Update(entity);
            return entity;
        }
    }
}
