using System;
using System.Collections.Generic;

namespace ContaFraudeDecorator
{
    public class FiltroMesCorrente : Filtro
    {
        public FiltroMesCorrente(Filtro outroFilto) : base(outroFilto) { }
        public FiltroMesCorrente() : base() { }

        public override List<Conta> Filtra(List<Conta> contas)
        {
            return contas.FindAll(o => o.DataAbertura.Month == DateTime.Now.Month) ?? new List<Conta>();
        }
    }
}
