using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3GFT
{
    public class Conta
    {
        public Conta()
        {
            this.Numero = 0;
            this.Titular = "";
            this.Saldo = 0;
        }

        public Conta(int numero, String titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        private int _numero;
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private String _titular;
        public String Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public void Rendimento()
        {
            Console.WriteLine("\n\nRendimento: " + this.Saldo);
        }
    }
}
