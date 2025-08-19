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
        public IPagamentoRepository PagamentoRepository { get; }
        public IUsuarioRepository UsuarioRepository { get; }
        public INotificacaoRepository NotificacaoNotify { get; }
        public IPedidoRepository PedidoRepository { get; }
        public IPedidoItemRepository PedidoItemRepository { get; }
        public IProdutoRepository ProdutoRepository { get; }
        public ILoginRepository  LoginRepository{ get; }
        public void Commit();
    }
}
