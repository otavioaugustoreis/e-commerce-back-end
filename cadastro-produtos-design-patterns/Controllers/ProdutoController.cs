using Cadastro.Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace cadastro_produtos_design_patterns.Controllers
{
    [ApiController]
    [Route("/{Controller}")]
    public class ProdutoController
        (IProdutoService _produtoService): ControllerBase
    {
        private readonly IProdutoService produtoService = _produtoService;
    }
}
