using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities.Pattern
{
    public class BaseEntity
    {
        public int PkId { get; set; }
        public DateTime DhInclusao { get; set; } = DateTime.Now;
        public BaseEntity()
        {

        }
        public BaseEntity(int pkId, DateTime dhInclusao)
        {
            PkId = pkId;
            DhInclusao = dhInclusao;
        }
    }
}
