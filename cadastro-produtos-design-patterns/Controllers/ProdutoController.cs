using AutoMapper;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Application.Services.Cache;
using Cadastro.Domain.Entities;
using cadastro_produtos_design_patterns.Model.Request;
using cadastro_produtos_design_patterns.Model.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

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


        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public async Task<ActionResult> Insert(ProdutoModelRequest produtoModelRequest)
        {
            var produto = _mapper.Map<ProdutoEntity>(produtoModelRequest);

            await produtoService.Insert(produto);

            var produtoMapped = _mapper.Map(produto, produtoModelRequest);

            return Ok(produtoMapped);
        }

        [HttpDelete("/{id:int}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Delete([FromQuery] int id)
        {
            var produtoEntity = await produtoService.Delete(id);

            if (!produtoEntity.IsSuccess)
            {
                return BadRequest(produtoEntity.ErrorMessage);
            }

            // Response.Headers.Add("X-Message", produtoEntity?.SuccessMessage);

            var produtoMapeado = mapper.Map<ProdutoModelRequest>(produtoEntity.Value);

            return Ok(id);
        }


        [HttpGet("/{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<ProdutoModelResponse>> GetById(int? id)
        {
            if (id == null || id < 0)
            {
                return BadRequest("Id não encontrado");
            }

            var produto = await produtoService?.GetId(id);

            if (!produto.IsSuccess)
            {
                return NotFound(produto.ErrorMessage);
            }

            var produtosMapped = mapper.Map<ProdutoModelResponse>(produto.Value);


            //Response.Headers.Add("X-Message", "Success");

            return Ok(produtosMapped);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<ProdutoModelRequest>>> GetAll()
        {
            try
            {
                var produtosEntitys = await produtoService.GetAll();

                if (!produtosEntitys.IsSuccess)
                {
                    return NotFound(produtosEntitys.ErrorMessage);
                }

                var produtosMapped = mapper.Map<List<ProdutoModelRequest>>(produtosEntitys.Value);


                // Response.Headers.Add("X-Message", "Success");

                return Ok(produtosMapped);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ProdutoModelResponse>> Update(int? id, ProdutoModelRequestUpdate produtoModelRequest)
        {


            return Ok();
        }

    }
}
