using AutoMapper;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Domain.Entities;
using cadastro_produtos_design_patterns.Model.Request;
using cadastro_produtos_design_patterns.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_produtos_design_patterns.Controllers
{

    [ApiController]
    [Route("/[Controller]")]
    public class UsuarioController
        (IUsuarioService _usuarioService,
        IMapper _mapper) : ControllerBase
    {

        private readonly IUsuarioService usuarioService = _usuarioService;
        private readonly IMapper mapper = _mapper; 

        [HttpPost]
        public async Task<ActionResult<UsuarioEntity>> CadastrarUsuario([FromBody]UsuarioModelRequest usuarioEntity)
        {
            
            var usuario = mapper.Map<UsuarioEntity>(usuarioEntity);

            var usuarioCriado = await usuarioService.Insert(usuario);
            
            return Ok(new
                        { Usuario = usuarioCriado.Value,
                          Message = usuarioCriado.SuccessMessage,
                     });
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModelResponse>>> GetUsuarios()
        {
            var usuarios = await usuarioService.GetAll();

            var usuariosModelResponse = mapper.Map<List<UsuarioModelResponse>>(usuarios.Value);

            return Ok(usuariosModelResponse);
        }
    }
}
