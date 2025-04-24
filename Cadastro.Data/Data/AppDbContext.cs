using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<PagamentoEntity> _Pagamento;

    }
}
