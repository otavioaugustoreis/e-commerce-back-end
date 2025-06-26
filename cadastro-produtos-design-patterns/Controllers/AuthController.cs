using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Domain.Entities;
using cadastro_produtos_design_patterns.Model.Request;
using cadastro_produtos_design_patterns.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_produtos_design_patterns.Controllers
{
    [ApiController]
    [Route("/[Controller]")]
    public class AuthController
        (ILoginService _loginService,
         IUsuarioService _usuarioService) : ControllerBase
    {
        private readonly ILoginService loginService = _loginService;
        private readonly IUsuarioService usuarioService = _usuarioService;

        [HttpGet()]
        public async Task<ActionResult<LoginModelResponse>> Login(LoginModelRequest loginModelRequest)
        {
            var usuario = await usuarioService.GetUsuarioEmail(loginModelRequest.Email);

            if (usuario.Value is null)
            {
                return BadRequest(usuario.ErrorMessage);
            }

            var token = loginService.Logar(usuario.Value);

            return Ok(new LoginModelResponse
                                           { 
                                            Token = token.Value
                                           });
        }


        [HttpPost("/registrarlogin")]
        public async Task<ActionResult> Registrar(int usuario, string senha)
        {
            var usuarioEntity = await usuarioService.GetId(usuario);

            if (usuarioEntity is null) return BadRequest(usuarioEntity.ErrorMessage);

            loginService.Registrar(usuarioEntity.Value.DsEmail, senha);

            return Ok("Login registrado com sucesso");
        }
    }
}
