using System.Reflection.PortableExecutable;

namespace cadastro_produtos_design_patterns.Model.Request
{
    public class ProdutoModelRequest
    {
        public int PkId { get; set; }
        public string DsNome  { get; set; }
        public int Quantidade { get; set; }
        public double NrValor { get; set; }
    }
}
