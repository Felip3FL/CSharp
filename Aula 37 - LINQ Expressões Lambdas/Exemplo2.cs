using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_37___LINQ_Expressões_Lambdas
{
    class Exemplo2
    {
        public static void Teste1()
        {

            Console.Write("\n\nPessoas usando LAMBDA\n");

            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa { Nome ="Felipe",Idade=45},
                new Pessoa { Nome ="Jefferson",Idade=25},
                new Pessoa { Nome ="Giovana",Idade=15},
                new Pessoa { Nome ="Janice",Idade=20}
            };

            var listaNovasPessoas = pessoas.Select(x => new
            {
                IdadePessoa = x.Idade,
                PrimeiraLetraDoNome = x.Nome[0]
            });

            foreach(var pessoa in listaNovasPessoas)
            {
                Console.WriteLine(pessoa);
            }
 
        }

    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
