using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34___LINQ
{
    class Exemplo3
    {
        public static void Teste()
        {
            Console.WriteLine("");
            Console.WriteLine("Exemplo 3");

            var pessoas = new List<Pessoa>
            {
                new Pessoa{idade = 15,nome="Felipe" },
                new Pessoa{idade = 18,nome="Julia" },
                new Pessoa{idade = 45,nome="Joao" },
                new Pessoa{idade = 60,nome="Pedro" },
                new Pessoa{idade = 10,nome="Fernando" }
            };

            var adolescentes = from p in pessoas
                               where p.idade > 12 && p.idade < 20
                               select p;

            Console.WriteLine("Nome dos Adolescentes");
            foreach (var ad in adolescentes)
            {
                Console.WriteLine(ad.nome);
            }
        }

        public class Pessoa
        {
            public int idade;
            public string nome;
        }

    }

}
