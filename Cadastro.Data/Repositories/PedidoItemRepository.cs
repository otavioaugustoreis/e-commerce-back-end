using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositories
{
    public class PedidoItemRepository : IRepository<PedidoItemEntity>
    {
        public Task<PedidoItemEntity> CreateAsync(PedidoItemEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PedidoItemEntity>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PedidoItemEntity> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<PedidoItemEntity> RemoveAsync(PedidoItemEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<PedidoItemEntity> UpdateAsync(PedidoItemEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
