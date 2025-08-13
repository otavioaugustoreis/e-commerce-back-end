using cadastro_produtos_design_patterns.Controllers;
using Ecommerce.Tests.UnitTests.ConfigureTests;
using Ecommerce.Tests.UnitTests.GET.Produto;
using Ecommerce.Tests.UnitTests.Patterns;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.PUT.Produto
{
    public class PutProdutoUnitTest : IClassFixture<ProdutoUnitTestController>, IPutTest
    {
        private readonly ProdutoController _controller;

        public PutProdutoUnitTest(ProdutoUnitTestController controller)
        {
            _controller = new ProdutoController(controller.produtoService, controller.mapper);
        }

        [Fact]
        public async Task Put_Update_Return_BadRequest()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public async Task Put_Update_Return_OkResult()
        {
            throw new NotImplementedException();
        }
    }
}

