using Cadastro.Domain.Entities;

namespace cadastro_produtos_design_patterns.Model.Request
{
    public class PedidoModelRequest
    {
        public int FkUsuario { get; set; }
        public List<ProdutoEntity> Produtos { get; set; }
        public int NrQuantidade { get; set; }
    }
}
