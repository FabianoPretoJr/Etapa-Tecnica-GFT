using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3GFT
{
    public class ContaPoupanca:Conta
    {
        private double _valorPoupanca;

        public double ValorPoupanca
        {
            get { return _valorPoupanca; }
            set { _valorPoupanca = value; }
        }


        public void RendimentoPoupanca()
        {
            this.ValorPoupanca = (this.Saldo * 0.05);

            Console.WriteLine("Saldo conta poupança: " + this.ValorPoupanca);
        }
    }
}
