using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3GFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            Console.Write("Digite o número da conta: ");
            c.Numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o títular da conta: ");
            c.Titular = Console.ReadLine();
            Console.Write("Digite o saldo da conta: ");
            c.Saldo = Convert.ToDouble(Console.ReadLine());

            c.Rendimento();
            cc.RendimentoCorrente();
            cp.RendimentoPoupanca();

            Console.ReadKey();
        }
    }
}
