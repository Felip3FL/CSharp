using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_18___Classe_e_Heranca
{
    class Pessoa2
    {

        public string nome;
        public string endereço;


        public Pessoa2()
        {
            Console.WriteLine("Criei uma pessoa 2");
        }

        public virtual void TesteSobreEscrever()
        {
            Console.WriteLine("TesteSobreEscrever 1");
        }

    }

    class PessoaFisica2 : Pessoa2
    {
        public string rg;
        public string cpf;


        public PessoaFisica2()
        {
            Console.WriteLine("Criei uma PessoaFisica 2");
        }

        public override void TesteSobreEscrever()
        {
            Console.WriteLine("TesteSobreEscrever 2");
        }

    }

    
}
