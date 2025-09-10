using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositories
{

    public class PedidoRepository
        (AppDbContext _appDbContext) : IPedidoRepository
    {

        private readonly AppDbContext appDbContext = _appDbContext;


        public async Task<PedidoEntity> CreateAsync(PedidoEntity entity)
        {
            appDbContext.Add(entity);
            return entity;
        }

        public async Task<IEnumerable<PedidoEntity>> GetAsync()
        {
            return appDbContext._Pedido.ToList();
        }

        public async Task<PedidoEntity> GetByIdAsync(int? id)
        {
            return appDbContext._Pedido.FirstOrDefault(p => p.PkId == id);
        }

        public async Task<PedidoEntity> RemoveAsync(PedidoEntity entity)
        {
            appDbContext.Remove(entity);
            return entity;
        }

        public async Task<PedidoEntity> UpdateAsync(PedidoEntity entity)
        {
            appDbContext.Update(entity);
            return entity;
        }
    }
}
