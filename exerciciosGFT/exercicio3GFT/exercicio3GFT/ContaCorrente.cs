using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3GFT
{
    public class ContaCorrente:Conta
    {
        public ContaCorrente():base()
        {
            this.ValorCorrente = 0;
        }

        public ContaCorrente(int numero, String titular, double saldo, double valorCorrente):base(numero, titular, saldo)
        {
            this.ValorCorrente = valorCorrente;
        }

        private double _valorCorrente;
        public double ValorCorrente
        {
            get { return _valorCorrente; }
            set { _valorCorrente = value; }
        }


        public void RendimentoCorrente(Conta c)
        {
            this.ValorCorrente = (c.Saldo * 0.03);

            Console.WriteLine("Rendimento conta corrente: " + this.ValorCorrente);
        }
    }
}
