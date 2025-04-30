using Cadastro.Application.Error;
using Cadastro.Data.Repositories;
using Cadastro.Data.Repositories.Pattern;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{

    public class UsuarioService : IUsuarioService
    {
        public IUnitOfWork unitOfWork { get; set; }

        public UsuarioService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Result<UsuarioEntity> CadastrarUsuario(UsuarioEntity usuarioEntity)
        {
            if (usuarioEntity is null) return Result<UsuarioEntity>.Failure("Usuário é nulo");


            unitOfWork.UsuarioRepository.CreateAsync(usuarioEntity);


            return Result<UsuarioEntity>.Success(usuarioEntity);
        }

        public Task<Result<UsuarioEntity>> GetUsuarios()
        {
            unitOfWork.UsuarioRepository.GetAsync();


            return Task.FromResult(
                new Result<UsuarioEntity>(true)
                );
        }
    }
}
