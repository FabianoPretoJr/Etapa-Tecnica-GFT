using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3GFT
{
    public class ContaPoupanca:Conta
    {
        public ContaPoupanca() : base()
        {
            this.ValorPoupanca = 0;
        }

        public ContaPoupanca(int numero, String titular, double saldo, double valorPoupanca) : base(numero, titular, saldo)
        {
            this.ValorPoupanca = valorPoupanca;
        }

        private double _valorPoupanca;
        public double ValorPoupanca
        {
            get { return _valorPoupanca; }
            set { _valorPoupanca = value; }
        }


        public void RendimentoPoupanca(Conta c)
        {
            this.ValorPoupanca = (c.Saldo * 0.05);

            Console.WriteLine("Rendimento conta poupança: " + this.ValorPoupanca);
        }
    }
}
