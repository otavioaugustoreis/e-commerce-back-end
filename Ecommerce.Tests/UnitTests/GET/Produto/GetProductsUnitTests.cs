using Cadastro.Domain.Entities;
using cadastro_produtos_design_patterns.Controllers;
using cadastro_produtos_design_patterns.Model.Response;
using Ecommerce.Tests.UnitTests.ConfigureTests;
using Ecommerce.Tests.UnitTests.Patterns;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Tests.UnitTests.GET.Produto
{
    public class GetProductsUnitTests : IClassFixture<ProdutoUnitTestController>, IGetTest<ProdutoEntity>
    {

        private readonly ProdutoController _controller;

        public GetProductsUnitTests(ProdutoUnitTestController controller)
        {
            _controller = new ProdutoController(controller.produtoService, controller.mapper);
        }


        [Fact]
        public async Task GetAll_Return_BadRequestResult()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public async Task GetAll_Return_ListOfProdutoDTO()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public async Task GetById_Return_BadRequest()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public async Task GetById_Return_NotFound()
        {
            var idProduto = 0;

            var data = await _controller.GetById(idProduto);

            data.Result.Should().BeOfType<NotFoundObjectResult>()
                .Which.StatusCode
                .Should()
                .Be(404);
        }
        [Fact]
        public async Task GetById_Return_OkResult()
        {
            var idProduto = 2;

            var data = await _controller.GetById(idProduto);

            Assert.True(data.Result != null);
            Assert.NotNull(data.Result);

            data.Result.Should().BeOfType<OkObjectResult>()
                .Which.StatusCode
                .Should()
                .Be(200);
        }
    }
}
