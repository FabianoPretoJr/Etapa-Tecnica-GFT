using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4GFT
{

    public class Imposto
    {
        private double _impostoCorrente;
        public double Impostocorrente
        {
            get { return _impostoCorrente; }
            set { _impostoCorrente = value; }
        }

        private double _impostoPoupanca;

        public double ImpostoPoupanca
        {
            get { return _impostoPoupanca; }
            set { _impostoPoupanca = value; }
        }


        public void ImprimirImposto()
        {
            Console.Write("Imposto do rendimento corrente: " + this.Impostocorrente);
            Console.Write("Impostp do rendimento poupança: " + this.ImpostoPoupanca);
        }

        private void CalcularImposto()
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            this.Impostocorrente = cc.ValorCorrente * 0.25;
            this.ImpostoPoupanca = cp.ValorPoupanca * 0.10;
        }
    }
}
