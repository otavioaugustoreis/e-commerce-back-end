using AutoMapper;
using Cadastro.Application.Services;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Domain.Entities;
using cadastro_produtos_design_patterns.Model.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_produtos_design_patterns.Controllers
{

   // [Authorize(Roles = "Usuario")]
    [ApiController]
    [Route("/[Controller]")]
    public class PedidoController
        (IPedidoService _pedidoService,
        IProdutoService _produtoService,
        IUsuarioService _usuarioService,
        IMapper _mapper) : ControllerBase
    {
        private readonly IPedidoService pedidoService = _pedidoService;
        private readonly IProdutoService produtoService = _produtoService;
        private readonly IUsuarioService usuarioService = _usuarioService;
        private readonly IMapper mapper = _mapper;

        [HttpPost]
        public async Task<ActionResult> CriarPedidoAsync(PedidoModelRequest pedidoModelRequest)
        {
            var usuarioId = pedidoModelRequest.FkUsuario;
            var usuario = await usuarioService.GetId(usuarioId);
            
            if (!usuario.IsSuccess)
            {
                return BadRequest(usuario.ErrorMessage);
            }

            var pedidoEntity = mapper.Map<PedidoEntity>(pedidoModelRequest);


            var pedido = pedidoService.Criar(pedidoEntity);
            

            return Ok("Pedido efetuado com sucesso " + pedidoEntity);
        }
        

    }
}
