using Cadastro.Domain.Entities.Pattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_produtos_design_patterns.Model.Request
{
    public class UsuarioModelRequest
    {
        public  string DsNome { get; set; }
        public int NrIdade   { get; set; }
        
    }
}
