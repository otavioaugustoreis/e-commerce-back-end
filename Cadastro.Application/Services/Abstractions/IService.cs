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
        Task<Result<T>> Insert(T entity);
        Task<Result<IEnumerable<T>>> GetAll();
        Task<Result<T>> GetId(int? id);
        Task<Result<T>> Delete(int id);
        Task<Result<T>> Update(int id);
    }
}
