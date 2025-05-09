using Cadastro.Application.Return;
using Cadastro.Application.Services.Factory;
using Cadastro.Application.Services.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Abstractions
{
    public interface INotificacaoService
    {
        Task NotificarTodosAsync(string destino, string mensagem);
    }
}
