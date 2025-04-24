using Cadastro.Domain.Entities.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class PedidoItemEntity : BaseEntity
    {
        public PedidoItemEntity(int pkId, DateTime dhInclusao) : base(pkId, dhInclusao)
        {
        }
        public  ProdutoEntity FkProduto { get; set; }
        public PedidoEntity FkPedido { get; set; }
        public  int  NrQuantidade { get; set; }
    }
}
