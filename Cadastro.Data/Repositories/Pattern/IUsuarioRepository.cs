using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositories.Pattern
{
    public interface IUsuarioRepository : IRepository<UsuarioEntity>
    {
        public Task<UsuarioEntity> GetUsuarioByEmail(string email);
    }
}
