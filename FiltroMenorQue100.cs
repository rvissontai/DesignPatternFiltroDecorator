using System.Collections.Generic;

namespace ContaFraudeDecorator
{
    public class FiltroMenorQue100 : Filtro
    {
        public FiltroMenorQue100(Filtro outroFilto) : base(outroFilto) { }
        public FiltroMenorQue100() : base() { }

        public override List<Conta> Filtra(List<Conta> contas)
        {
            return contas.FindAll(o => o.Saldo < 100) ?? new List<Conta>();
        }
    }
}
