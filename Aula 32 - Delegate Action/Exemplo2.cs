using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_32___Delegate_Action
{
    class Exemplo2
    {
        public static void Teste()
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //define delegate Action
            Action<int> delagateActionExemplo = new Action<int>(CalcularPotencia);
            Array.ForEach(numeros, CalcularPotencia);

            Console.WriteLine("");
        }

        private static void CalcularPotencia(int n)
        {
            Console.WriteLine("{0:d} ao quadrado = {1:d} ", n, n * n);
        }
    }
}
