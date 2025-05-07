using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositories
{
    internal class PedidoRepository : IRepository<PedidoEntity>
    {
        public Task<PedidoEntity> CreateAsync(PedidoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PedidoEntity>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PedidoEntity> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<PedidoEntity> RemoveAsync(PedidoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<PedidoEntity> UpdateAsync(PedidoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
