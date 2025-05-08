using Cadastro.Application.Error;
using Cadastro.Domain.Entities;
using System.Runtime.CompilerServices;

namespace Cadastro.Application.Services.Abstractions
{
    public interface IUsuarioService
    {
        Result<UsuarioEntity> CadastrarUsuario(UsuarioEntity usuarioEntity);
        Task<Result<UsuarioEntity>> GetUsuarios();
    }
}