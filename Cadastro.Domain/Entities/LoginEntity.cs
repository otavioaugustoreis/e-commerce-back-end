﻿using Cadastro.Domain.Entities.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class LoginEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
