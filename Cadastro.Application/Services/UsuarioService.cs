using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
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

    public class UsuarioService
        (IUnitOfWork _unitOfWork) : IUsuarioService
    {
        private readonly IUnitOfWork unitOfWork = _unitOfWork;


        public async Task<Result<UsuarioEntity>> Criar(UsuarioEntity usuarioEntity)
        {
            if (usuarioEntity is null) return Result<UsuarioEntity>.Failure("Usuário é nulo");


            unitOfWork.UsuarioRepository.CreateAsync(usuarioEntity);


            return Result<UsuarioEntity>.Success(usuarioEntity);
        }

        public Task<Result<List<UsuarioEntity>>> Get()
        {
            unitOfWork.UsuarioRepository.GetAsync();


            return Task.FromResult(
                new Result<List<UsuarioEntity>>(true)
                );
        }

        public Task<Result<UsuarioEntity>> GetId(int id)
        {
            unitOfWork.UsuarioRepository.GetByIdAsync(id);

            return Task.FromResult(
                new Result<UsuarioEntity>(true)
                );
        }
    }
}
