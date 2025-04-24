using Cadastro.Domain.Entities.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public abstract class PagamentoEntity : BaseEntity
    {
        public PedidoEntity PedidoEntity { get; set; }

        public PagamentoEntity(int pkId, DateTime dhInclusao) : base(pkId, dhInclusao)
        {
        }
    }
}
