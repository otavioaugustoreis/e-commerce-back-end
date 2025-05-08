using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Event
{
    public class PagamentoAprovadoEvent : INotification
    {

        public int PagamentoId { get; }
        public decimal  Valor { get; set; }

        public PagamentoAprovadoEvent(int pagamentoId, decimal valor)
        {
            PagamentoId = pagamentoId;
            Valor = valor;
        }
    }
}
