using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.EntitiesConfiguration
{
    public class PedidoItemConfiguration : IEntityTypeConfiguration<PedidoItemEntity>
    {
        public void Configure(EntityTypeBuilder<PedidoItemEntity> builder)
        {
            builder.ToTable("TB_PEDIDOITEM");

            builder.HasKey(p => p.PkId);

            builder.HasOne(p => p.ProdutoEntity)
                .WithMany(p => p.PedidoItemEntity)
                .HasForeignKey(t => t.FkProduto);
            
            builder.HasOne(p => p.PedidoEntity)
                .WithMany(p => p.PedidoItemEntity)
                .HasForeignKey(t => t.FkPedido);
        }
    }
}
