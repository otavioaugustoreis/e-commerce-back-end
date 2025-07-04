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
        public async Task<ActionResult> Inserir(ProdutoModelRequest produtoModelRequest)
        {
            var produto = _mapper.Map<ProdutoEntity>(produtoModelRequest);

            await produtoService.Criar(produto);

            var produtoMapped = _mapper.Map(produto, produtoModelRequest);

            return Ok(produtoMapped);
        }

        [HttpDelete("/{id}")]
        public async Task<ActionResult> Remover([FromQuery] int id)
        {
            var produtoEntity = await produtoService.Deletar(id);

            if (!produtoEntity.IsSuccess)
            {
                return BadRequest(produtoEntity.ErrorMessage);
            }

            Response.Headers.Add("X-Message", produtoEntity?.SuccessMessage);

            var produtoMapeado = mapper.Map<ProdutoModelRequest>(produtoEntity.Value);

            return Ok(id);  
        }


        [HttpGet]
        public async Task<ActionResult<List<ProdutoModelRequest>>> GetAll()
        {
            var produtosEntitys = await produtoService.Get();

            if (!produtosEntitys.IsSuccess)
            {
                return BadRequest(produtosEntitys.ErrorMessage);
            }

            var produtosMapped = mapper.Map<List<ProdutoModelRequest>>(produtosEntitys.Value);

            Response.Headers.Add("X-Message", produtosEntitys?.SuccessMessage);

            return Ok(produtosMapped);
        }

    }
}
