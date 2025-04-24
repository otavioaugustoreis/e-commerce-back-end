using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Enums
{
    public enum PedidoStatus : int
    {
        PENDENTE = 1,
        APROVADO = 2,
        AGUARDANDO_PAGAMENTO = 3
    }
}
