using Cadastro.Application.Services;
using Cadastro.Application.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_produtos_design_patterns.Controllers
{

    [Authorize(Roles = "Usuario")]
    [ApiController]
    [Route("/[Controller]")]
    public class PedidoController
        (IPedidoService _pedidoService) : ControllerBase
    {
        private readonly  IPedidoService pedidoService = _pedidoService;

    }
}
