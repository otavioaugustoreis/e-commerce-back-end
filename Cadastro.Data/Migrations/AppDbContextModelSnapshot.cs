﻿// <auto-generated />
using System;
using Cadastro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cadastro.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cadastro.Domain.Entities.LoginEntity", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"));

                    b.Property<DateTime>("DhInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ds_email");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkId");

                    b.ToTable("TB_LOGIN", (string)null);
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.NotificacaoEntity", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"));

                    b.Property<DateTime>("DhInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("DsMensagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FkPedido")
                        .HasColumnType("int");

                    b.HasKey("PkId");

                    b.HasIndex("FkPedido");

                    b.ToTable("TB_NOTIFICACAO", (string)null);
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.PagamentoEntity", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"));

                    b.Property<DateTime>("DhInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NrCartaoMascarado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("NrQrCode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PagamentoStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Parcelas")
                        .HasColumnType("int");

                    b.Property<string>("TipoPagamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("PkId");

                    b.ToTable("TB_PAGAMENTO", (string)null);
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.PedidoEntity", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"));

                    b.Property<DateTime>("DhInclusao")
                        .HasColumnType("datetime2");

                    b.Property<int>("FkPagamento")
                        .HasColumnType("int");

                    b.Property<int>("FkUsuario")
                        .HasColumnType("int");

                    b.Property<double>("NrValor")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("PkId");

                    b.HasIndex("FkPagamento")
                        .IsUnique();

                    b.HasIndex("FkUsuario");

                    b.ToTable("TB_PEDIDO", (string)null);
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.PedidoItemEntity", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"));

                    b.Property<DateTime>("DhInclusao")
                        .HasColumnType("datetime2");

                    b.Property<int>("FkPedido")
                        .HasColumnType("int");

                    b.Property<int>("FkProduto")
                        .HasColumnType("int");

                    b.Property<int>("NrQuantidade")
                        .HasColumnType("int");

                    b.HasKey("PkId");

                    b.HasIndex("FkPedido");

                    b.HasIndex("FkProduto");

                    b.ToTable("TB_PEDIDOITEM", (string)null);
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.ProdutoEntity", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"));

                    b.Property<DateTime>("DhInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("DsNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NrValor")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("PkId");

                    b.ToTable("TB_PRODUTO", (string)null);
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.UsuarioEntity", b =>
                {
                    b.Property<int>("PkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkId"));

                    b.Property<DateTime>("DhInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("DsEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ds_email");

                    b.Property<string>("DsNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrIdade")
                        .HasColumnType("int");

                    b.HasKey("PkId");

                    b.ToTable("TB_USUARIO", (string)null);
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.NotificacaoEntity", b =>
                {
                    b.HasOne("Cadastro.Domain.Entities.PedidoEntity", "PedidoEntity")
                        .WithMany("NotificacaoEntity")
                        .HasForeignKey("FkPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PedidoEntity");
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.PedidoEntity", b =>
                {
                    b.HasOne("Cadastro.Domain.Entities.PagamentoEntity", "PagamentoEntity")
                        .WithOne("PedidoEntity")
                        .HasForeignKey("Cadastro.Domain.Entities.PedidoEntity", "FkPagamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cadastro.Domain.Entities.UsuarioEntity", "UsuarioEntity")
                        .WithMany("PedidoEntity")
                        .HasForeignKey("FkUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PagamentoEntity");

                    b.Navigation("UsuarioEntity");
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.PedidoItemEntity", b =>
                {
                    b.HasOne("Cadastro.Domain.Entities.PedidoEntity", "PedidoEntity")
                        .WithMany("PedidoItemEntity")
                        .HasForeignKey("FkPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cadastro.Domain.Entities.ProdutoEntity", "ProdutoEntity")
                        .WithMany("PedidoItemEntity")
                        .HasForeignKey("FkProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PedidoEntity");

                    b.Navigation("ProdutoEntity");
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.PagamentoEntity", b =>
                {
                    b.Navigation("PedidoEntity")
                        .IsRequired();
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.PedidoEntity", b =>
                {
                    b.Navigation("NotificacaoEntity");

                    b.Navigation("PedidoItemEntity");
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.ProdutoEntity", b =>
                {
                    b.Navigation("PedidoItemEntity");
                });

            modelBuilder.Entity("Cadastro.Domain.Entities.UsuarioEntity", b =>
                {
                    b.Navigation("PedidoEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
