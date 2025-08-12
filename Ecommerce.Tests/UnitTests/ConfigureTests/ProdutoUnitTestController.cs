using AutoMapper;
using Cadastro.Data;
using Cadastro.Data.UnitOfWork;
using cadastro_produtos_design_patterns.Mapper;
using cadastro_produtos_design_patterns.Model.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.ConfigureTests
{
    public class ProdutoUnitTestController
    {
        public IUnitOfWork unitOfWork;
        public IMapper mapper;
        public static DbContextOptions<AppDbContext>  dbContextOptions {  get; }
        public static string ConnectionString = @"Data Source=DESKTOP-GF22MH3\\SQLEXPRESS;Initial Catalog=db_ecommerce;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static ProdutoUnitTestController()
        {

        }

        public ProdutoUnitTestController()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainMapperProfile());
            });

            mapper = config.CreateMapper();
            var context = new AppDbContext(dbContextOptions);
            unitOfWork = new UnitOfWork(_appDbContext: context);
       }
    }
}
