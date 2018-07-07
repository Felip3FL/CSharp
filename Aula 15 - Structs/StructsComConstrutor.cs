using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15___Structs
{
    class StructsComConstrutor
    {

        public struct Pessoa
        {
            public string Nome;
            public int Idade;

            //construtor =>  Pessoa p = new Pessoa(1.98,90,26.45)
            public Pessoa(string _nome, int _idade)
            {
                Nome = _nome;
                Idade = _idade;
            }

            //construtor sem parâmetros não é permitido
            //public Pessoa()
            //{
            //    Nome = _nome;
            //    Idade = _idade;
            //}
        }

        public void UsandoConstrutor()
        {
            Console.WriteLine("Instanciando uma Struct com construtor");
            Pessoa Felipe = new Pessoa("Felip3FL", 45);

            Console.WriteLine("Exibindo:");

            Console.WriteLine("Nome  : {0}", Felipe.Nome);
            Console.WriteLine("Idade : {0}", Felipe.Idade);
            Console.WriteLine("");
            Console.ReadKey();
        }

    }
}
