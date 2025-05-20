using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Abstractions
{
    public interface IProdutoService : IService<ProdutoEntity>
    {
    }
}
