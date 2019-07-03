using System.Collections.Generic;

namespace ContaFraudeDecorator
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; private set; }

        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public Filtro() { }

        public abstract List<Conta> Filtra(List<Conta> contas);

        protected List<Conta> Proximo(List<Conta> contas)
        {
            if (OutroFiltro != null) return OutroFiltro.Filtra(contas);
            else return new List<Conta>();
        }
    }
}
