﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Cache
{
    public interface ICacheService
    {
        Task SetAsync(string key, string value);
        Task<string> GetAsync(string key);
    }
}
