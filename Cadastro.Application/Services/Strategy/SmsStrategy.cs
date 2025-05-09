using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Strategy
{
    public class SmsStrategy : ILocalMessageStrategy
    {
        public async Task EnviarMenssagem(string mensagem)
        {
            throw new NotImplementedException();
        }
    }
}
