using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class LoginService
         (IUnitOfWork _unitOfWork,
          ITokenService _tokenService) : ILoginService
    {

        private readonly IUnitOfWork unitOfWork = _unitOfWork;
        private readonly ITokenService tokenService = _tokenService;
        public Result<string> Logar(UsuarioEntity usuarioEntity)
        { 
           //Validação se a senha está correta
            
            var usuarioToken = new UsuarioEntityToken()
            {
                DsNome = usuarioEntity.DsNome,
                // Roles = ??
            };

            string token = tokenService.Generate(usuarioToken);

            return Result<string>.Success("Token gerado com sucesso");
        }

        public Result<LoginEntity> Registrar(string email, string senha)
        {
        
        }
    }
}
