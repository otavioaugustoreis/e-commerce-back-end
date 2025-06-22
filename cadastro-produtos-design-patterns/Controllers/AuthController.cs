using Cadastro.Application.Services.Abstractions;
using Cadastro.Domain.Entities;
using cadastro_produtos_design_patterns.Model.Request;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_produtos_design_patterns.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class AuthController
        (ITokenService _tokenSerivce,
         IUsuarioService _usuarioService) : ControllerBase
    {
        private readonly ITokenService tokenService = _tokenSerivce;
        private readonly IUsuarioService usuarioService = _usuarioService;

        [HttpGet("/login")]
        public async Task<ActionResult> Login(LoginModelRequest loginModelRequest)
        {
            var usuario = await usuarioService.GetUsuarioEmailSenha(loginModelRequest.Email); 

            var token = tokenService.Generate(usuario.Value);


            return Ok();
        }

        public async Task<ActionResult> Registrar(LoginModelRequest loginModelRequest)
        {
            return Ok();
        }
    }
}
