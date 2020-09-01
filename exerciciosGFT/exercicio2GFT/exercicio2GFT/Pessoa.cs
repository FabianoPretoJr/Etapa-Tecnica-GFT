using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2GFT
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.Nome = "";
            this.Endereco = "";
            this.Telefone = "";
        }


        private String _nome;
        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private String _endereco;
        public String Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private String _telefone;
        public String Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Endereço: " + this.Endereco);
            Console.WriteLine("Telefone: " + this.Telefone);
        }
    }
}
