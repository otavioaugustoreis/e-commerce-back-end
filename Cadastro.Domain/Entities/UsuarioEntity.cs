using Cadastro.Domain.Entities.Pattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class UsuarioEntity : BaseEntity
    {
        public  string DsNome { get; set; }
        public int NrIdade   { get; set; }
        public List<PedidoEntity> PedidoEntity { get; set; }
        public UsuarioEntity() : base()
        {
        }
        public string DsEmail { get; set; }
    }
}
