using System.Collections.Generic;

namespace ContaFraudeDecorator
{
    public class FiltroMaiorQueQuinhentosMil : Filtro
    {
        public FiltroMaiorQueQuinhentosMil(Filtro outroFilto) : base(outroFilto) { }
        public FiltroMaiorQueQuinhentosMil() : base() { }

        public override List<Conta> Filtra(List<Conta> contas)
        {
            return contas.FindAll(o => o.Saldo > 500000) ?? new List<Conta>();
        }
    }
}
