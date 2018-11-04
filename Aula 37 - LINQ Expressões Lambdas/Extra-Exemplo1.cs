using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_37___LINQ_Expressões_Lambdas
{
    class Extra_Exemplo1
    {

        public static void Extra1()
        {
            Console.Write("\n\nLAMBDA Extra 1\n");

            // Cria um array de numeros inteiros
            int[] numeros = { 2343, 5349, 6039, 4326, 3038, 1987, 8762, 1098 };

            // Encontra o numero que é maior que 7000
            int numero = Array.Find(numeros, n => n > 7000);

            // exibe o primeiro numero encontrado que atente o criterio
            Console.WriteLine("Encontrado: n = {0} ", numero);
        }

        public static void Extra2()
        {
            Console.Write("\n\nLAMBDA Extra 2\n");

            //define uma lista de inteiros (usamos o recurso inicilizadores de coleções)
            List<int> Numeros = new List<int> { 1, 9, 7, 4, 5, 6, 3, 8, 2, 10, 11, 12, 13, 14, 15 };

            //realizar uma ordenação ascendente
            foreach (var n in Numeros.OrderByDescending(i => i))
            {
                Console.WriteLine(n);
            }

            //Fazer a ordenação ascendente, pegar os números menores que 8 e pegar os 5 números do resultado obtido
            var resultado5 = Numeros.OrderByDescending(i => i).Where(i => i < 8).Take(5);
            foreach (var n in resultado5)
            {
                Console.WriteLine(n);
            }

            //=============================================================================================

            //Verificar um condição(verifica os números da lista são maiores que 100)
            bool resultado1 = Numeros.All(i => i > 100);
            Console.WriteLine(resultado1);
            //--------------------------------------------------------------
            bool resultado8 = true;
            foreach (int i in Numeros)
            {
                if (i >= 100)
                {
                    resultado8 = false;
                }
            }


            //Verificar um condição (verifica um número da lista é igual a 10 )
            bool resultado2 = Numeros.Any(i => i == 10);
            Console.WriteLine(resultado2);
            //------------------------------------------------------------------
            bool resultado11 = true;
            foreach (int i in Numeros)
            {
                if (i == 10)
                {
                    resultado11 = true;
                }
            }


            //Obter os 4 números do topo da Lista
            var subconjunto = Numeros.Take(4);
            foreach (var n in subconjunto)
            {
                Console.WriteLine(n);
            }
            //----------------------------------------------------
            var valores = new List<int>();
            for (int i = 0; i <= 4; i++)
            {
                if (i < Numeros.Count)
                {
                    valores.Add(i);
                }
            }

            //Localizando itens - localiza o numero 6
            int numero = Numeros.Find(n => n == 6);
            Console.WriteLine(numero);
            //---------------------------------------------------
            foreach (int i in Numeros)
            {
                if (i == 6)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}

