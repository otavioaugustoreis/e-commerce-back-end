using Cadastro.Domain.Entities.Pattern;
using Cadastro.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class PedidoEntity : BaseEntity
    {
        public UsuarioEntity UsuarioEntity { get; set; }
        public PedidoStatus Status { get; set; }
        public PagamentoEntity PagamentoEntity { get; set; }
        public List<PedidoItemEntity> PedidoItemEntity { get; set; }
        public List<NotificacaoEntity> NotificacaoEntity { get; set; }
        public PedidoEntity(int pkId, DateTime dhInclusao) : base(pkId, dhInclusao)
        {
        }
    }
}
