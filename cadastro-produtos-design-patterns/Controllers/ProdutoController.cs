using AutoMapper;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Domain.Entities;
using cadastro_produtos_design_patterns.Model.Request;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_produtos_design_patterns.Controllers
{
    [ApiController]
    [Route("/[Controller]")]
    public class ProdutoController
        (IProdutoService _produtoService,
        IMapper _mapper) : ControllerBase
    {
        private readonly IProdutoService produtoService = _produtoService;
        private readonly IMapper mapper = _mapper;

        [HttpPost]
        public async Task<ActionResult> InserirProduto(ProdutoModelRequest produtoModelRequest)
        {
            var produto = _mapper.Map<ProdutoEntity>(produtoModelRequest);

            await produtoService.Criar(produto);

            var produtoMapped = _mapper.Map(produto, produtoModelRequest);

            return Ok(produtoMapped);
        }
    }
}
