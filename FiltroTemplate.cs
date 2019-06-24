﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaFraudeDecorator
{
    public abstract class Filtro
    {
        public abstract IList<Conta> Filtra(IList<Conta> contas);
    }
}
