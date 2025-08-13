using AutoMapper;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Application.Services.Cache;
using Cadastro.Domain.Entities;
using cadastro_produtos_design_patterns.Model.Request;
using cadastro_produtos_design_patterns.Model.Response;
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
        public async Task<ActionResult> Insert(ProdutoModelRequest produtoModelRequest)
        {
            var produto = _mapper.Map<ProdutoEntity>(produtoModelRequest);

            await produtoService.Criar(produto);

            var produtoMapped = _mapper.Map(produto, produtoModelRequest);

            return Ok(produtoMapped);
        }

        [HttpDelete("/{id}")]
        public async Task<ActionResult> Delete([FromQuery] int id)
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

        [HttpGet("/{id}")]
        public async Task<ActionResult<ProdutoModelResponse>> GetById(int id)
        {
            var produto = await produtoService.GetId(id);

            if (!produto.IsSuccess)
            {
                return NotFound(produto.ErrorMessage);
            }

            var produtosMapped = mapper.Map<ProdutoModelResponse>(produto.Value);


            //Response.Headers.Add("X-Message", "Success");

            return Ok(produtosMapped);
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

            Response.Headers.Add("X-Message", "Success");

            return Ok(produtosMapped);
        }

        [HttpPut]
        public async Task<ActionResult<ProdutoModelRequest>> Update()
        {
            return Ok();
        }

    }
}
