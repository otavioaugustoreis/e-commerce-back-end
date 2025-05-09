using Cadastro.Application.Return;
using Cadastro.Application.Services.Strategy;
using Cadastro.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Factory
{
    public interface ILocalMessageFactory
    {
        Result<ILocalMessageStrategy> RetornarTipoMensagem(TipoNotificacao tipoNotificacao);
    }
}
