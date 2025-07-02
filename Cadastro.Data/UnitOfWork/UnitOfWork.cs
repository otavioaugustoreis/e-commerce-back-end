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
            IRepository<PagamentoEntity> _pagamentoRepository,
            IUsuarioRepository _usuarioRepository,
            IRepository<NotificacaoEntity> _notificaoRepository,
            IRepository<PedidoEntity> _pedidoRepository,
            IRepository<PedidoItemEntity> _pedidoItemRepository,
            IRepository<ProdutoEntity> _produtoRepository,
            AppDbContext _appDbContext,
            ILoginRepository _loginRepository) : IUnitOfWork
    {
        private readonly IRepository<PagamentoEntity> pagamentoRepository = _pagamentoRepository;
        private readonly IUsuarioRepository usuarioRepository = _usuarioRepository;
        private readonly IRepository<NotificacaoEntity> notificaoRepository = _notificaoRepository;
        private readonly IRepository<PedidoEntity> pedidoRepository = _pedidoRepository;
        private readonly IRepository<PedidoItemEntity> pedidoItemRepository = _pedidoItemRepository;
        private readonly IRepository<ProdutoEntity> produtoRepository = _produtoRepository;
        private readonly ILoginRepository loginRepository = _loginRepository;


        private readonly AppDbContext appDbContext = _appDbContext;

       
        public IRepository<PagamentoEntity> PagamentoRepository { get => pagamentoRepository ?? new PagamentoRepository(appDbContext); }
        public IUsuarioRepository UsuarioRepository { get => usuarioRepository ?? new UsuarioRepository(appDbContext); }

        public IRepository<NotificacaoEntity> NotificacaoNotify { get => notificaoRepository ?? new NotificacaoRepository(appDbContext); }

        public IRepository<PedidoEntity> PedidoRepository { get => pedidoRepository ?? new PedidoRepository(appDbContext); }

        public IRepository<PedidoItemEntity> PedidoItemRepository { get => pedidoItemRepository ?? new PedidoItemRepository(appDbContext); }

        public IRepository<ProdutoEntity> ProdutoRepository { get => produtoRepository ?? new ProdutoRepository(appDbContext); }

        public ILoginRepository LoginRepository { get => loginRepository ?? new LoginRepository(appDbContext); }

        public void Commit()
        {
            appDbContext.SaveChanges();
        }
    }
}
