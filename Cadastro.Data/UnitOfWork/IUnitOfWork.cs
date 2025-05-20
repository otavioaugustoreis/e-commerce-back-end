using Cadastro.Data.Repositories;
using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepository<PagamentoEntity> PagamentoRepository { get; }
        public  IRepository<UsuarioEntity> UsuarioRepository { get; }
        public void Commit();
    }
}
