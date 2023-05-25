﻿using AluguelCarro.src.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Interface
{
    internal interface IClienteDAO
    {
        public List<Cliente> getClientesInativos(DateTime desdeDe);
    }
}