using cadastro_produtos_design_patterns.Controllers;
using Ecommerce.Tests.UnitTests.ConfigureTests;
using Ecommerce.Tests.UnitTests.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.POST.Produto
{
    public class PostProdutoUnitTests : IClassFixture<ProdutoUnitTestController>, IPostTest
    {
        private readonly ProdutoController _controller;

        public PostProdutoUnitTests(ProdutoUnitTestController controller)
        {
            _controller = new ProdutoController(controller.produtoService, controller.mapper);
        }

        [Fact]
        public async Task Post_Return_BadRequest()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public async Task Post_Return_CreatedStatusCode()
        {
            throw new NotImplementedException();
        }
    }
}
