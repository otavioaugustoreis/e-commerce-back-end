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
    public class NotificacaoConfiguration : IEntityTypeConfiguration<NotificacaoEntity>
    {
        public void Configure(EntityTypeBuilder<NotificacaoEntity> builder)
        {
            builder.ToTable("TB_NOTIFICACAO");

            builder.HasKey(p => p.PkId);

            builder.HasOne(p => p.PedidoEntity)
                .WithMany(p => p.NotificacaoEntity)
                .HasForeignKey(p => p.FkPedido);
        }
    }
}
