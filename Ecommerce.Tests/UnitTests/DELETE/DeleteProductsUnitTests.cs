using cadastro_produtos_design_patterns.Controllers;
using Ecommerce.Tests.UnitTests.ConfigureTests;
using Ecommerce.Tests.UnitTests.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.DELETE
{
    public class DeleteProductsUnitTests : IClassFixture<ProdutoUnitTestController>, IDeleteTest
    {
        private readonly ProdutoController _controller;

        public DeleteProductsUnitTests(ProdutoUnitTestController controller)
        {
            _controller = new ProdutoController(controller.produtoService, controller.mapper);
        }

        [Fact]
        public async Task Put_Delete_Return_NotFound()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public async Task Put_Delete_Return_OkResult()
        {
            throw new NotImplementedException();
        }
    }
}
