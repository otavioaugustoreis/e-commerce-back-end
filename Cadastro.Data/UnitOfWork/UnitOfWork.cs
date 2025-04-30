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

        private PagamentoRepository pagamentoRepository;
        private UsuarioRepository usuarioRepository;
        
        private AppDbContext appDbContext;

        public UnitOfWork(PagamentoRepository pagamentoRepository, UsuarioRepository usuarioRepository, AppDbContext appDbContext)
        {
            this.pagamentoRepository = pagamentoRepository;
            this.usuarioRepository = usuarioRepository;
            this.appDbContext = appDbContext;
        }

        public PagamentoRepository PagamentoRepository { get => pagamentoRepository ?? new PagamentoRepository(appDbContext); }
        public UsuarioRepository UsuarioRepository { get => usuarioRepository ?? new UsuarioRepository(appDbContext); }

        public void Commit()
        {
            appDbContext.SaveChanges();
        }
    }
}
