using Cadastro.Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_produtos_design_patterns.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class PagamentoController(IPagamentoService _pagamentoService) : ControllerBase
    {
        private readonly IPagamentoService pagamentoService = _pagamentoService;
    
    
    }

}
