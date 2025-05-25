using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Application.Services.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Composite
{
    public class NotificacaoServiceComposite(IEnumerable<ILocalMessageStrategy> _notificacoes) : INotificacaoService
    {
        private readonly IEnumerable<ILocalMessageStrategy> notificacoes = _notificacoes;

        public async Task NotificarTodosAsync(string destino, string mensagem)
        {
            foreach (var meio in notificacoes)
            {
                await meio.EnviarMenssagem(mensagem);
            }
        }
    }
}
