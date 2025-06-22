using Cadastro.Application;
using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Domain.Entities;
using System.Runtime.CompilerServices;

namespace Cadastro.Application.Services.Abstractions
{

}    public interface IUsuarioService : IService<UsuarioEntity>
    {
        public Task<Result<UsuarioEntity>> GetUsuarioEmailSenha(string email);
    }