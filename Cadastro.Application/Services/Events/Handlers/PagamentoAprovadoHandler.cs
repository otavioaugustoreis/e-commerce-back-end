using Cadastro.Application.Services.Event;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Events.Handlers
{
    public class PagamentoAprovadoHandler : INotificationHandler<PagamentoAprovadoEvent>
    {   


        public Task Handle(PagamentoAprovadoEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Pagamento aprovado! ID: {notification.PagamentoId}, Valor: R${notification.Valor}");
            return Task.CompletedTask;
        }


    }
}
