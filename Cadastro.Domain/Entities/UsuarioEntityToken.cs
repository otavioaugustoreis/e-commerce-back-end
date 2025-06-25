using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class UsuarioEntityToken
    {
        public string[] Roles { get; set; }

        public string DsNome { get; set; }
    }
}
