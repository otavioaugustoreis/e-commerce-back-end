using Cadastro.Domain.Enums;
using cadastro_produtos_design_patterns.Model.Request;
using System.Net;

namespace cadastro_produtos_design_patterns.Model.Response
{
    public class PedidoModelResponse
    {
        public int PkId { get; set; }
        public DateTime DhInclusao { get; set; } = DateTime.Now;
        public PedidoStatus Status { get; set; }
        public UsuarioModelResponse UsuarioEntity { get; set; }
        public List<ProdutoModelRequest> Produtos { get; set; }
        public PagamentoModelResponse Pagamento { get; set; }
    }
}
