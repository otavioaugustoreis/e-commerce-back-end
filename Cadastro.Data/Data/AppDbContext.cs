using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<PagamentoEntity>? _Pagamento { get; set; }
        public DbSet<UsuarioEntity>? _Usuario { get; set; }
        public DbSet<PedidoItemEntity>? _PedidoItem { get; set; }
        public DbSet<PedidoEntity>? _Pedido { get; set; }
        public DbSet<ProdutoEntity>? _Produto { get; set; }
        public DbSet<NotificacaoEntity>? _Notificacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext)
            .Assembly);
        }
}
}
