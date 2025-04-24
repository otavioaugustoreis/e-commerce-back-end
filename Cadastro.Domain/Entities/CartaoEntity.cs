using Cadastro.Domain.Entities.Pattern;
using Cadastro.Domain.Enums;
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

        public CartaoEntity() : base(TipoPagamento.CARTAO) 
        {
        }
    }
}
