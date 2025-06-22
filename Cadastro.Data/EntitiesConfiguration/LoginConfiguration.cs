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
    public class LoginConfiguration : IEntityTypeConfiguration<LoginEntity>
    {
        public void Configure(EntityTypeBuilder<LoginEntity> builder)
        {
            builder.ToTable("TB_LOGIN");

            builder.HasKey(p => p.PkId);

            builder.Property(p => p.Email)
                .HasColumnType("varchar(50)")
                .HasColumnName("ds_email");
        }
    }
}
