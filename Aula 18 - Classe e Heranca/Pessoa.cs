using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_18___Classe_e_Heranca
{
    class Pessoa
    {
        public string nome;
        public string endereço;

        public Pessoa()
        {
            Console.WriteLine("Criei uma pessoa");
        }

        public void TesteOcutarMembros()
        {
            Console.WriteLine("Teste 1");
        }

    }

    class PessoaFisica : Pessoa
    {
        public string rg;
        public string cpf;

        public PessoaFisica()
        {
            Console.WriteLine("Criei uma PessoaFisica");
        }

        new public void TesteOcutarMembros()
        {
            Console.WriteLine("Teste 2");
        }

    }

    //class Aluno : PessoaFisica
    //{
    //    public string matricula;

    //}


    //class PessoaJuridica : Pessoa
    //{
    //    public string rg;
    //    public string cpf;

    //    public PessoaJuridica()
    //    {
    //        Console.WriteLine("Criei uma PessoaJuridica");
    //    }

    //}




}
