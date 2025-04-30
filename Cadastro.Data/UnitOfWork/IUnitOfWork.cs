using Cadastro.Data.Repositories;
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
        public PagamentoRepository PagamentoRepository { get; }
        public UsuarioRepository UsuarioRepository { get; }
        public void Commit();
    }
}
