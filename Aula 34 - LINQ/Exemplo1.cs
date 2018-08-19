using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34___LINQ
{
    class Exemplo1
    {

        public static void Teste()
        {

            Console.WriteLine("");
            Console.WriteLine("Exemplo 1");

            string[] saudacoes = { "Olá mundo", "Olá LINQ", "Olá Felipe" };

            var item = from s in saudacoes
                       where s.EndsWith("LINQ")
                       select s;

            foreach (var i in item)
                Console.WriteLine(i);

        }
    }
}
