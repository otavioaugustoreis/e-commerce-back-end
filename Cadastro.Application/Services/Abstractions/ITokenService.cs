using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Abstractions
{
    public interface ITokenService 
    {
        public string Generate(UsuarioEntityToken usuarioEntity);
    }
}
