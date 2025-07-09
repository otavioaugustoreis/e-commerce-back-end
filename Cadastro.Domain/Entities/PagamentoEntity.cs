using Cadastro.Domain.Entities.Pattern;
using Cadastro.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public  class PagamentoEntity : BaseEntity
    {
        public PedidoEntity PedidoEntity { get; set; }
        public decimal Valor { get; set; }

        public PagamentoStatus PagamentoStatus { get; set; }

        public  TipoPagamento TipoPagamento { get; set; }
        public Guid NrQrCode { get; set; } = Guid.NewGuid();
        public string NrCartaoMascarado { get; set; } 
        public int? Parcelas { get; set; } 
        public PagamentoEntity() { }

        public  PagamentoEntity(TipoPagamento TipoPagamento) 
        {
        }

    }
}
