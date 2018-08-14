using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_32___Delegate_Action
{
    class Exemplo3
    {
        public static void Teste()
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //define delegate Action com expressão Lambda
            Array.ForEach(numeros, n => Console.WriteLine(n * n));

            Console.WriteLine("");
        }

        //private static void CalcularPotencia(int n)
        //{
        //    Console.WriteLine("{0:d} ao quadrado = {1:d} ", n, n * n);
        //}
    }
}
