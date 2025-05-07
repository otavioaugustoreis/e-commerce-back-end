using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositories
{
    public class NotificacaoRepository : IRepository<NotificacaoEntity>
    {
        public Task<NotificacaoEntity> CreateAsync(NotificacaoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NotificacaoEntity>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NotificacaoEntity> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<NotificacaoEntity> RemoveAsync(NotificacaoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<NotificacaoEntity> UpdateAsync(NotificacaoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
