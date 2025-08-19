using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositories
{
    public class PedidoItemRepository
        (AppDbContext _appDbContext) : IPedidoItemRepository
    {

        private readonly AppDbContext appDbContext = _appDbContext;

        public async Task<PedidoItemEntity> CreateAsync(PedidoItemEntity entity)
        {
            appDbContext.Add<PedidoItemEntity>(entity);
            return entity;
        }

        public async Task<IEnumerable<PedidoItemEntity>> GetAsync()
        {
            return appDbContext._PedidoItem.ToList();
        }

        public async Task<PedidoItemEntity> GetByIdAsync(int? id)
        {
            return appDbContext._PedidoItem.FirstOrDefault(p => p.PkId == id);
        }

        public async Task<PedidoItemEntity> RemoveAsync(PedidoItemEntity entity)
        {
            appDbContext.Remove<PedidoItemEntity>(entity);
            return entity;
        }

        public async Task<PedidoItemEntity> UpdateAsync(PedidoItemEntity entity)
        {

            appDbContext.Update<PedidoItemEntity>(entity);
            return entity;
        }
    }
}
