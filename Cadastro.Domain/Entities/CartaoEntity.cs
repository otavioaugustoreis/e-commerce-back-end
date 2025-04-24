using Cadastro.Domain.Entities.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class CartaoEntity : PagamentoEntity
    {
        public int NrCartao { get; set; }

        public CartaoEntity(int pkId, DateTime dhInclusao) : base(pkId, dhInclusao)
        {
        }
    }
}
