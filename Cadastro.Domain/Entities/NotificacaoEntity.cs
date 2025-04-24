using Cadastro.Domain.Entities.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class NotificacaoEntity : BaseEntity
    {
        public string DsMensagem { get; set; }
        public  PedidoEntity  PedidoEntity { get; set; }

        public int FkPedido { get; set; }
        public NotificacaoEntity(int pkId, DateTime dhInclusao) : base(pkId, dhInclusao)
        {
        }
    }
}
