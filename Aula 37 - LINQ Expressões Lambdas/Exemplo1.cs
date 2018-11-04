using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_37___LINQ_Expressões_Lambdas
{
    class Exemplo1
    {

        public static void Teste1()
        {
            Console.Write("\n\nUsando LAMBDA\n");
            List<int> numeros = new List<int> { 11, 37, 14, 52, 67, 99, 16 };
            List<int> impares = numeros.Where(n => n % 2 == 1).ToList();

            foreach (var n in impares)
            {
                Console.Write(n + " ");
            }

        }

        public static void Teste2()
        {
            Console.Write("\n\nOrdenando usando LAMBDA\n");
            List<int> numeros = new List<int> { 11, 37, 14, 52, 67, 99, 16 };

            foreach (var n in numeros.OrderBy(n => n))
            {
                Console.Write(n + " ");
            }

        }


        public static void Teste3()
        {
            Console.Write("\n\nTem número maior que 500?\n");
            List<int> numeros = new List<int> { 11, 37, 14, 52, 67, 99, 16 };

            //todos os elemento tem fazem parte do teste, se um é false,
            //os outros são false tambem
            bool resultado = numeros.All(n => n > 500);
            Console.Write(resultado);

        }

    }
}
