using Cadastro.Application.Services;
using Cadastro.Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_produtos_design_patterns.Controllers
{
    public class PedidoController
        (IPedidoService _pedidoService) : ControllerBase
    {
        private readonly  IPedidoService pedidoService = _pedidoService;

    }
}
