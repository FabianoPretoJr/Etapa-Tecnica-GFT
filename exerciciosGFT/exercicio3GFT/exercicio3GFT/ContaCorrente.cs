using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3GFT
{
    public class ContaCorrente:Conta
    {
        private double _valorCorrente;

        public double ValorCorrente
        {
            get { return _valorCorrente; }
            set { _valorCorrente = value; }
        }


        public void RendimentoCorrente()
        {
            this.ValorCorrente = (this.Saldo * 0.03);

            Console.WriteLine("Rendimento conta corrente: " + this.ValorCorrente);
        }
    }
}
