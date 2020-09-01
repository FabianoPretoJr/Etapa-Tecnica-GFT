using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1GFT
{
    class ValoresImpares
    {
        private int _inicial;
        public int Inicial
        {
            get { return _inicial; }
            set {
                if (value > 0)
                {
                    _inicial = value;
                }
                else
                {
                    _inicial = 0;
                }
            }
        }

        private int _final;
        public int Final
        {
            get { return _final; }
            set {
                if (value > this.Inicial)
                {
                    _final = value;
                }
                else
                {
                    _final = 0;
                }
            }
        }

        public void Imprimiralores()
        {
            for (int i = this.Inicial; i <= this.Final; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(" " + i);
                }             
            } 
        }
    }
}
