using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20___Tratamento_Excecoes
{
    class Divisao
    {

        public static void RealizarDivisaoTryCatch()
        {
            Console.WriteLine("Informe o valor do numero 1 ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do numero 2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int resultado = num1 / num2;
                Console.WriteLine(" {0} / {1} = {2} ", num1, num2, resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro divisão por zero");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }



        public static void RealizarDivisaoTryCatchFinally()
        {
            Console.WriteLine("Informe o valor do numero 1 ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do numero 2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int resultado = num1 / num2;
                Console.WriteLine(" {0} / {1} = {2} ", num1, num2, resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro divisão por zero");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Executado o código do bloco finally");
            }
            Console.ReadKey();
        }


        public static void RealizarDivisaoMensagemDeErroEspecifica()
        {
            try
            {
                Console.WriteLine("Informe um numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                int resultado = 100 / numero;
                Console.WriteLine(" O resultado é : " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("ERRO: Caractere de número inválido!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERRO: O número não pode ser zero!");
            }
            catch (Exception ex)  // tratamento mais genérico fica por último
            {
                Console.WriteLine("ERRO: " + ex.Source);
            }
            Console.ReadKey();
        }

    }
}
