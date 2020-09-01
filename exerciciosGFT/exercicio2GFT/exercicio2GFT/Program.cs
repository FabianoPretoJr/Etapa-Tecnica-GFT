using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2GFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.Write("Digite seu nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite seu endereco: ");
            p.Endereco = Console.ReadLine();
            Console.Write("Digite seu telefone: ");
            p.Telefone = Console.ReadLine();

            Console.Clear();

            p.ImprimirDados();
            Console.ReadKey();
        }
    }
}
