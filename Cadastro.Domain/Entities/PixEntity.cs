using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class PixEntity : PagamentoEntity
    {
        public Guid NrQrCode { get; set; }
        public PixEntity(int pkId, DateTime dhInclusao) : base(pkId, dhInclusao)
        {
        }
    }
}
