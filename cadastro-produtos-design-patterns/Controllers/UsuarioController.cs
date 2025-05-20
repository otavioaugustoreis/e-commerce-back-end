using Cadastro.Application.Services.Abstractions;
using Cadastro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_produtos_design_patterns.Controllers
{

    [ApiController]
    [Route("/{Controller}")]
    public class UsuarioController
        (IUsuarioService _usuarioService) : ControllerBase
    {

        private readonly IUsuarioService usuarioService = _usuarioService;


        [HttpPost]
        public async Task<ActionResult<UsuarioEntity>> CadastrarUsuario(UsuarioEntity usuarioEntity)
        {
            
            return Ok();
        }
    }
}
