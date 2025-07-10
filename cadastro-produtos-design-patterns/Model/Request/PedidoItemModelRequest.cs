namespace cadastro_produtos_design_patterns.Model.Request
{
    public class PedidoItemModelRequest
    {
        public int FkProduto  { get; set; }
        public int NrQuantidade { get; set; }
    }
}
