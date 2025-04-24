using Cadastro.Domain.Entities.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class ProdutoEntity : BaseEntity
    {
        public  string  DsNome { get; set; }
        public int  Quantidade { get; set; }
        public List<PedidoItemEntity> PedidoItemEntity { get; set; }
        public ProdutoEntity(int pkId, DateTime dhInclusao) : base(pkId, dhInclusao)
        {

        }
    }
}
