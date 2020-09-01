using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1GFT
{
    class Program
    {
        static void Main(string[] args)
        {
            ValoresImpares vi = new ValoresImpares();

            Console.WriteLine("Digite o valor inicial: ");
            vi.Inicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor final: ");
            vi.Final = Convert.ToInt32(Console.ReadLine());

            vi.Imprimiralores();

            Console.ReadKey();
        }
    }
}
