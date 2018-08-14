using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_33___Delegate_Predicate
{
    class Exemplo2
    {
        public static void Teste1()
        {
            // Cria um array de números inteiros
            int[] numeros = { 2343, 5349, 6039, 4326, 3038, 1987, 8762, 1098 };
       
            // Encontra o numero que é maior que 7000
            int numero = Array.Find(numeros, n => n > 7000);

            // exibe o primeiro numero encontrado que atente o critério
            Console.WriteLine("Encontrado: n = {0} ", numero);

        }
    }
}
