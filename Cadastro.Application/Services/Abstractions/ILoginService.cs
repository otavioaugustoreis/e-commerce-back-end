using Cadastro.Application.Return;
using Cadastro.Domain.Entities;

namespace Cadastro.Application.Services.Abstractions
{
    public interface ILoginService
    {
        public Result<string> Logar(UsuarioEntity usuarioEntity);
        public Result<LoginEntity> Registrar(string email, string senha);                                                                                                                                                                                  
    }
}