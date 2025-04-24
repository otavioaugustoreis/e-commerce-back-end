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
    public class PedidoConfiguration : IEntityTypeConfiguration<PedidoEntity>
    {
        public void Configure(EntityTypeBuilder<PedidoEntity> builder)
        {
            builder.ToTable("TB_PEDIDO");
            
            builder.HasKey(p => p.PkId);

            builder.HasOne(p => p.PagamentoEntity)
                .WithOne(p => p.PedidoEntity)
                .HasForeignKey<PedidoEntity>(p => p.FkPagamento);

        }
    }
}
