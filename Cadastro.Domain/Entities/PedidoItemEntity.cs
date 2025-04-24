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
        public PedidoItemEntity()
        {
        }
        public  ProdutoEntity ProdutoEntity { get; set; }
        public PedidoEntity PedidoEntity { get; set; }
        public int FkPedido { get; set; }
        public int FkProduto { get; set; }
        public  int  NrQuantidade { get; set; }

    }
}
