using Cadastro.Application.Services.Abstractions;
using Cadastro.Application.Services.Event;
using Cadastro.Application.Services.Factory;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Events.Handlers
{
    public class PagamentoAprovadoHandler(INotificacaoService _notificacaoService) : INotificationHandler<PagamentoAprovadoEvent>
    {

        private readonly INotificacaoService notificacaoService = _notificacaoService;

        public Task Handle(PagamentoAprovadoEvent notification, CancellationToken cancellationToken)
        {
            var message = $"Pagamento aprovado! ID: {notification.PagamentoId}, Valor: R${notification.Valor}";

            notificacaoService.NotificarTodosAsync("", message);
            
            return Task.CompletedTask;

        }


    }
}
