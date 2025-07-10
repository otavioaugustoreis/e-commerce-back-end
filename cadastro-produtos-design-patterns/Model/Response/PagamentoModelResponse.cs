using Cadastro.Domain.Enums;

namespace cadastro_produtos_design_patterns.Model.Response
{
    public class PagamentoModelResponse
    {
        public int PkId { get; set; }
        public PagamentoStatus PagamentoStatus { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
    }
}
