using cadastro_produtos_design_patterns.Controllers;
using cadastro_produtos_design_patterns.Model.Request;
using cadastro_produtos_design_patterns.Model.Response;
using Ecommerce.Tests.UnitTests.ConfigureTests;
using Ecommerce.Tests.UnitTests.GET.Produto;
using Ecommerce.Tests.UnitTests.Patterns;
using FluentAssertions;
using Microsoft.AspNetCore.Http.HttpResults;
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
            var idProduto = 1;

            ProdutoModelRequestUpdate produtoDTO = new()
            {
                PkId = idProduto,
                DsNome = "Produto Atualizado",
                NrValor = 200.00,
                Quantidade = 3
            };

            var result = await _controller.Update(idProduto, produtoDTO) as ActionResult<ProdutoModelResponse>;

            result.Result.Should().BeOfType<NotFoundObjectResult>().Which.StatusCode.Should().Be(404);
        }
        [Fact]
        public async Task Put_Update_Return_OkResult()
        {
            var idProduto = 1;

            ProdutoModelRequestUpdate produtoDTO = new()
            {
                PkId = idProduto,
                DsNome = "Produto Atualizado",
                NrValor = 200.00,
                Quantidade = 3
            };


            var result = await _controller.Update(idProduto, produtoDTO) as ActionResult<ProdutoModelResponse>;

            result.Should().NotBeNull();
            result.Result.Should().BeOfType<OkObjectResult>();
        }
    }
}

