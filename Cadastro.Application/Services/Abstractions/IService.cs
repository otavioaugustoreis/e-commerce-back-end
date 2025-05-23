using Cadastro.Application.Return;
using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Abstractions
{
    public interface IService<T>
    {
        Task<Result<T>> Criar(T entity);
        Task<Result<IEnumerable<T>>> Get();
        Task<Result<T>> GetId(int id);
    }
}
