using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_08___Conversao_de_Tipos
{
    class Conversao
    {
        static void Main(string[] args)
        {

            var conversao = new Conversao();

            conversao.ConversoesImplicitas();
            conversao.ConversoesExplicitas();
            conversao.ConversaoComToXXX();
            conversao.ConvesaoComParse();
            conversao.ConvesaoComOutrosMetodos();

            Console.ReadKey();

        }

        private void ConversoesImplicitas()
        {
            //Aqui eu não perco dados
            //Estou convertendo de menor precisão para maior precisão
            int i = 12309531;
            double d = i;

            Console.WriteLine("ConversoesImplicitas valor 12309531");
            Console.WriteLine("Valor: {0}", i);
        }

       private void ConversoesExplicitas()
        {
            double d1 = 123.09531;
            int i1 = (int)d1; //Esse é o cast, uma conversão forçada

            Console.WriteLine("ConversoesExplicitas valor 123.09531");
            Console.WriteLine("Valor: {0}", i1);

        }

        private void ConversaoComToXXX()
        {

            string numero = "2000"; 
            int valor1 = Convert.ToInt32(numero);
            short valor2 = Convert.ToInt16(numero);
            double valor3 = Convert.ToDouble(numero);
            DateTime data = Convert.ToDateTime("01/01/2012");

            Console.WriteLine("conversaoComToXXX");
            Console.WriteLine("{0}\n {1}\n {2}\n {3}\n ", valor1,valor2,valor3,data);

        }

        private void ConvesaoComParse()
        {

            string numero = "2000";

            int valor1 = Int32.Parse(numero);
            short valor2 = Int16.Parse(numero);
            DateTime data = DateTime.Parse("01/01/2012");

            Console.WriteLine("convesaoComParse");
            Console.WriteLine("{0}\n {1}\n {2}\n ", valor1, valor2, data);
        }


        private void ConvesaoComOutrosMetodos()
        {

            int i = 100;
            string valor = i.ToString();

            Console.WriteLine("ConvesaoComOutrosMetodos");
            Console.WriteLine("{0}", valor);

        }


    }
}
