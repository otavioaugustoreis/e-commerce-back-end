using cadastro_produtos_design_patterns.Controllers;
using Ecommerce.Tests.UnitTests.ConfigureTests;
using Ecommerce.Tests.UnitTests.Patterns;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.DELETE.Produto
{
    public class DeleteProductsUnitTests : IClassFixture<ProdutoUnitTestController>, IDeleteTest
    {
        private readonly ProdutoController _controller;

        public DeleteProductsUnitTests(ProdutoUnitTestController controller)
        {
            _controller = new ProdutoController(controller.produtoService, controller.mapper);
        }

        [Fact]
        public async Task Delete_Return_NotFound()
        {
            int idProduto = -1;

            var result = _controller.Delete(idProduto);

            result.Result.Should().BeOfType<NotFoundObjectResult>().Which.StatusCode.Should().Be(404);
        }
        [Fact]
        public async Task Delete_Return_OkResult()
        {
            int idProduto = 2;

            var result = _controller.Delete(idProduto);

            result.Should().NotBeNull();
            result.Result.Should().BeOfType<OkObjectResult>().Which.StatusCode.Should().Be(200); 
        }
    }
}
