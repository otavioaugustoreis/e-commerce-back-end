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

        [HttpPost()]
        public async Task<ActionResult<LoginModelResponse>> Login([FromBody]LoginModelRequest loginModelRequest)
        {
            var usuario = await usuarioService.GetUsuarioEmail(loginModelRequest.Email);

            if (!usuario.IsSuccess)
            {
                return BadRequest(usuario.ErrorMessage);
            }
            //Tentar fazer uma fila, de login
            var token = loginService.Logar(usuario.Value);

            if(!token.IsSuccess)
            {
                loginService.Registrar(loginModelRequest.Email, loginModelRequest.Senha);
            }

            token = loginService.Logar(usuario.Value);


            return Ok(new LoginModelResponse
                                           { 
                                            Token = token.Value
                                           });
        }
    }
}
