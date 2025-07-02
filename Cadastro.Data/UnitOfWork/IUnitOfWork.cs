﻿using Cadastro.Data.Repositories;
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
        public IUsuarioRepository UsuarioRepository { get; }
        public IRepository<NotificacaoEntity> NotificacaoNotify { get; }
        public IRepository<PedidoEntity> PedidoRepository { get; }
        public IRepository<PedidoItemEntity> PedidoItemRepository { get; }
        public IRepository<ProdutoEntity> ProdutoRepository { get; }
        public IRepository<LoginEntity> LoginRepository { get; }
        public void Commit();
    }
}
