using Cadastro.Application.Return;
using Cadastro.Application.Services.Strategy;
using Cadastro.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Factory
{
    public class LocalMessageFactory : ILocalMessageFactory
    {

        private readonly IServiceProvider services;

        public LocalMessageFactory(IServiceProvider services)
        {
            this.services = services;
        }

        public Result<ILocalMessageStrategy> RetornarTipoMensagem(TipoNotificacao tipoNotificacao)
        {
            return tipoNotificacao switch
            {
                TipoNotificacao.EMAIL => Result<ILocalMessageStrategy>.Success(services.GetRequiredService<EmailMessageStrategy>()),
                TipoNotificacao.SMS => Result<ILocalMessageStrategy>.Success(services.GetRequiredService<SmsStrategy>()),
                _ => Result<ILocalMessageStrategy>.Failure("Notificação não identificada")

            };
        }
    }
}
