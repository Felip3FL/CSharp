using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06___Estruturas_de_repeticao
{
    class Repeticao
    {
        static void Main(string[] args)
        {

            Repeticao exibir = new Repeticao();
            //exibir.RepetiFor();
            //exibir.RepetiDoWhile();
            //exibir.RepetiWhile();
            //exibir.RepetiGoTo();
            //exibir.RepetiForeach();
            exibir.BreakEContinue();

            Console.WriteLine("Pressione uma tecla para encerrar");
            Console.ReadKey();



        }

        public void BreakEContinue()
        {
            while (true)
            {
                Console.Write("Informe um número (Pressione 9 para encerrar) :");
                // Obtem um numero
                int valor = int.Parse(Console.ReadLine());
                // Se o numero é divisivel por 2 retorna ao inicio (resto é zero)
                if ((valor % 2) == 0)
                {
                    Console.WriteLine("O número é divisivel por 2 : {0}", valor);
                    continue;
                }
                // Se o numero é igual a 9 sai do laço
                if (valor == 9)
                {
                    break;
                }
                Console.WriteLine("O número não é divisivel por 2 : {0}", valor);
                // Pausa
                //Console.ReadKey();
            }
            Console.WriteLine("Você sai do laço while");

        }

        public void RepetiForeach()
        {
            int[] numeros = new int[] { 0, 1, 2, 3, 5, 8, 13 };
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        public void RepetiDoWhile()
        {


            int i = 10;
            do
            {
                Console.WriteLine("i = {0}", i);
                i--;
            } while (i >= 0);


        }

        public void RepetiFor()
        {


            for (int i = 0; i <= 50; i++)
            { //não inclui um caractere de nova linha (WriteLine)
                Console.Write("{0} ", i);
                if (i % 10 == 0)
                {
                    Console.WriteLine("\t\t {0} ", i);
                }
            }

        }

        public void RepetiGoTo()
        {


            int i = 0;
            repetir:
            Console.WriteLine("i ={0}", i);
            i++;
            if (i < 10)
                goto repetir;



        }

        public void RepetiWhile()
        {


            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("i = {0}", i);
                i++;
            }



        }

    }
}