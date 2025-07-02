using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

            //Validação se a senha está correta e se existe

            string senha = "";

            if(string.IsNullOrEmpty(senha))
            {
                return Result<string>.Failure("Usuário sem registro de login");
            }

            
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
            if (string.IsNullOrEmpty(email))
                return Result<LoginEntity>.Failure("E-mail não pode ser vazio");

            if (string.IsNullOrEmpty(senha))
                return Result<LoginEntity>.Failure("Senha não pode ser vazia");

            unitOfWork.

            
        }
    }
}
