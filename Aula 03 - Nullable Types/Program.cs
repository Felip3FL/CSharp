using System;

namespace Aula_03___Nullable_Types
{
    class Program
    {
        static void Main()
        {

            /////////////////////////////////////////////////////////////////////////////////

            //Atribuindo valor e exibindo na tela
            int? valor1 = null;
            Console.WriteLine("Valor 1:");
            Console.WriteLine("{0} ", valor1.ToString());

            //Atribuindo valor e exibindo na tela
            int? valor2 = 90;
            Console.WriteLine("Valor 2:");
            Console.WriteLine("{0} ", valor2);

            //Conversão
            int? valor3 = 100;              //implicitamente
            int valor4 = (int)valor3;       //explicitamente usando CAST -> (int)

            /////////////////////////////////////////////////////////////////////////////////


          //DateTime? dataNascimento = DateTime.now;
            DateTime? dataNascimento = null;
            if (dataNascimento.HasValue)
            {
                Console.WriteLine("Data de nascimento foi definida");
            }
            else
            {
                Console.WriteLine("Data de nascimento é null");
            }

            //A propriedade Value retorna um valor se houver um atribuído, 
            //de outra forma será lançada uma exceção System.InvalidOperationException;
            try
            {
                Console.WriteLine(dataNascimento.Value);
            } catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                Console.ReadKey();
            }
            


            /////////////////////////////////////////////////////////////////////////////////


            Console.ReadKey();




        }
    }
}
