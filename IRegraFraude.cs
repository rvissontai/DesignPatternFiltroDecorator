using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaFraudeDecorator
{
    interface IRegraFraude
    {
        IRegraFraude ProximaRegraFraude { get; set; }
        bool ValidarConta(Conta conta);
    }
}
