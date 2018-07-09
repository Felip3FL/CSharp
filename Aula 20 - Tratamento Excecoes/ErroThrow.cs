using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20___Tratamento_Excecoes
{
    class ErroThrow
    {

        public static void SimulandoThrow()
        {
            string felipe = null;

            if (felipe == null)
            {
                throw new ArgumentNullException();
            }

            Console.Write("A string FELIPE é null"); // não será executada
        }


        public static void ChamandoThrowComVetor()
        { 
            try
            {
                SimulandoThrowComVetor();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        private static void SimulandoThrowComVetor()
        {
            try
            {
                int[] MeuVetor = new int[5];
                for (int contador = 0; contador < 10; contador++)
                {
                    MeuVetor[contador] = contador;
                }
            }
            catch (Exception)
            {
                //Console.WriteLine("Ocorreu o erro : " + ex.Message);
                throw new Exception("Indice do array excede o tamanho do mesmo");
            }
        }



        public static void SimulandoThrowIdade()
        {
            Console.WriteLine("Informe sua idade : ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 18)
            {
                throw new ExceptionIdadeInvalida("Idade mínima: 18 anos");
            }
            Console.ReadKey();
        }

        private class ExceptionIdadeInvalida : ApplicationException
        {
            public ExceptionIdadeInvalida(string message)
                : base(message)
            { }
        }


    }
}
