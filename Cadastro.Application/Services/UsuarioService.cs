using Cadastro.Application.Return;
using Cadastro.Application.Services.Abstractions;
using Cadastro.Data.Repositories;
using Cadastro.Data.Repositories.Pattern;
using Cadastro.Data.UnitOfWork;
using Cadastro.Domain.Entities;
using System;
using System.Collections;
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


        public async Task<Result<UsuarioEntity>> Insert(UsuarioEntity usuarioEntity)
        {
            if (usuarioEntity is null) return Result<UsuarioEntity>.Failure("Usuário é nulo");

            await unitOfWork.UsuarioRepository.CreateAsync(usuarioEntity);
            unitOfWork.Commit();

            return Result<UsuarioEntity>.Success(usuarioEntity, "Usuario cadastrado com sucesso.");
       }

        public Task<Result<UsuarioEntity>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<IEnumerable<UsuarioEntity>>> GetAll()
        {
            var usuarios = await unitOfWork.UsuarioRepository.GetAsync();

            if(usuarios is null || !usuarios.Any()) 
                        return Result<IEnumerable<UsuarioEntity>>.Failure("Não existem usuários com esse Id");

            return Result<IEnumerable<UsuarioEntity>>.Success(usuarios);
        }

        public async Task<Result<UsuarioEntity>> GetId(int? id)
        {
            var usuario = await unitOfWork.UsuarioRepository.GetByIdAsync(id);

            if (usuario is null )
                return Result<UsuarioEntity>.Failure("Não existem usuários");

            return Result<UsuarioEntity>.Success(usuario);
        }

        public async Task<Result<UsuarioEntity>> GetUsuarioEmail(string email)
        {
            var usuario = await unitOfWork.UsuarioRepository.GetUsuarioByEmail(email);

            if (usuario is null) return Result<UsuarioEntity>.Failure("Usuário não cadastrado.");

            return Result<UsuarioEntity>.Success(usuario);
        }

        public Task<Result<UsuarioEntity>> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
