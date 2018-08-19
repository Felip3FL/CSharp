using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34___LINQ
{
    class Exemplo2
    {
        public static void Teste()
        {

            Console.WriteLine("");
            Console.WriteLine("Exemplo 2");

            int[] numeros = { 1, 7, 4, 2, 91, 12, 23, 37, 42, 100, 5, 13, 290, 55, 13, 80 };

            var todosNumeros = from n in numeros
                               where n > 40
                               orderby n descending
                               select n;

            foreach(object n in todosNumeros)
            {
                Console.WriteLine(" " + n);
            }

        }
    }
}
