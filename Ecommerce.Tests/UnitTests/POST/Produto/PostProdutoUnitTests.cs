using cadastro_produtos_design_patterns.Controllers;
using cadastro_produtos_design_patterns.Model.Request;
using cadastro_produtos_design_patterns.Model.Response;
using Ecommerce.Tests.UnitTests.ConfigureTests;
using Ecommerce.Tests.UnitTests.Patterns;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
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
            ProdutoModelRequest produtoDTO = new()
            {
                DsNome = "Camiseta branca básica",
                NrValor = 200.00,
                Quantidade = 3
            };

            var produto = _controller.Insert(produtoDTO);

            produto.Result.Should().BeOfType<BadRequestObjectResult>()
                .Subject.StatusCode.Should().Be(400);
        }

        [Fact]
        public async Task Post_Return_CreatedStatusCode()
        {
            ProdutoModelRequest produtoDTO = new()
            {
                DsNome = "Camiseta branca básica",
                NrValor = 200.00,
                Quantidade = 3
            };

            var produto = _controller.Insert(produtoDTO);

            produto.Result.Should().BeOfType<OkObjectResult>()
                .Subject.StatusCode.Should().Be(200);
        }
    }
}
