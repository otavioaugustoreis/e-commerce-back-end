using Cadastro.Data.Repositories;
using Cadastro.Data.Repositories.Pattern;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.UnitOfWork
{
    public class UnitOfWork(
            IPagamentoRepository _pagamentoRepository = null,
            IUsuarioRepository _usuarioRepository =  null,
            INotificacaoRepository _notificaoRepository =  null,
            IPedidoRepository _pedidoRepository =  null,
            ILoginRepository _loginRepository = null,
            IPedidoItemRepository _pedidoItemRepository =  null,
            IProdutoRepository _produtoRepository =  null,
            AppDbContext _appDbContext = null) : IUnitOfWork
    {
        

        private readonly IPagamentoRepository pagamentoRepository = _pagamentoRepository;
        private readonly IUsuarioRepository usuarioRepository = _usuarioRepository;
        private readonly INotificacaoRepository notificaoRepository = _notificaoRepository;
        private readonly IPedidoRepository pedidoRepository = _pedidoRepository;
        private readonly IPedidoItemRepository pedidoItemRepository = _pedidoItemRepository;
        private readonly IProdutoRepository produtoRepository = _produtoRepository;
        private readonly ILoginRepository loginRepository = _loginRepository;
        private readonly AppDbContext appDbContext = _appDbContext;

        public IPagamentoRepository PagamentoRepository { get => pagamentoRepository ?? new PagamentoRepository(appDbContext); }
        public IUsuarioRepository UsuarioRepository { get => usuarioRepository ?? new UsuarioRepository(appDbContext); }

        public INotificacaoRepository NotificacaoNotify { get => notificaoRepository ?? new NotificacaoRepository(appDbContext); }

        public IPedidoRepository PedidoRepository { get => pedidoRepository ?? new PedidoRepository(appDbContext); }

        public IPedidoItemRepository PedidoItemRepository { get => pedidoItemRepository ?? new PedidoItemRepository(appDbContext); }

        public IProdutoRepository ProdutoRepository { get => produtoRepository ?? new ProdutoRepository(appDbContext); }

        public ILoginRepository LoginRepository { get => loginRepository ?? new LoginRepository(appDbContext); }

        public void Commit()
        {
            appDbContext.SaveChanges();
        }
    }
}
