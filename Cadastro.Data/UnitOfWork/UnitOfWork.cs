using Cadastro.Data.Data;
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
    public class UnitOfWork : IUnitOfWork
    {
        private IRepository<PagamentoEntity> pagamentoRepository;
        private IRepository<UsuarioEntity> usuarioRepository;
        private IRepository<NotificacaoEntity> notificaoRepository;
        private IRepository<PedidoEntity> pedidoRepository;
        private IRepository<PedidoItemEntity> pedidoItemRepository;
        private IRepository<ProdutoEntity> produtoRepository;

        private AppDbContext appDbContext;

        public UnitOfWork(PagamentoRepository pagamentoRepository, UsuarioRepository usuarioRepository, AppDbContext appDbContext)
        {
            this.pagamentoRepository = pagamentoRepository;
            this.usuarioRepository = usuarioRepository;
            this.appDbContext = appDbContext;
        }

        public IRepository<PagamentoEntity> PagamentoRepository { get => pagamentoRepository ?? new PagamentoRepository(appDbContext); }
        public IRepository<UsuarioEntity> UsuarioRepository { get => usuarioRepository ?? new UsuarioRepository(appDbContext); }

        public IRepository<NotificacaoEntity> NotificacaoNotify { get => notificaoRepository ?? new NotificacaoRepository(appDbContext); }

        public IRepository<PedidoEntity> PedidoRepository { get => pedidoRepository ?? new PedidoRepository(appDbContext); }

        public IRepository<PedidoItemEntity> PedidoItemRepository { get => pedidoItemRepository ?? new PedidoItemRepository(appDbContext); }

        public IRepository<ProdutoEntity> ProdutoRepository { get => produtoRepository ?? new ProdutoRepository(appDbContext); }

        public void Commit()
        {
            appDbContext.SaveChanges();
        }
    }
}
