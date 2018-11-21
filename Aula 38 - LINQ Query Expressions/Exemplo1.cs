using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_38___LINQ_Query_Expressions
{
    class Exemplo1
    {

        public void SintaxeDeConsultaQuerySyntax1()
        {
            Console.WriteLine("\n");

            //Fonte de dados
            int[] numeros = { 90, 71, 82, 93, 75, 82 };

            //Expressão de Consulta (Query Expression)
            IEnumerable<int> consulta = from n in numeros
                                        where n > 80
                                        orderby n descending
                                        select n;
            foreach(int resultado in consulta)
            {
                Console.WriteLine(resultado);
            }

        }

        public void SintaxeDeConsultaQuerySyntax2()
        {
            Console.WriteLine("\n");

            //Fonte de dados
            int[] numeros = { 90, 71, 82, 93, 75, 82 };

            //Expressão de Consulta (Query Expression)
            var consulta = from n in numeros
                                        where n > 80
                                        orderby n descending
                                        select n;
            foreach (int resultado in consulta)
            {
                Console.WriteLine(resultado);
            }

        }

        public void ExemploComDoisFrom()
        {
            Console.WriteLine("\n");

            int[] numeros = { 1, 2, 3 };
            char[] letras = { 'a', 'b', 'c' };

            var consulta = from numero in numeros
                           from letra in letras
                           select new { numero, letra };

            foreach(var combinacao in consulta)
            {
                Console.WriteLine("{0} x {1}", combinacao.numero, combinacao.letra);
            }

        }



        //public static void SintaxeDeMetodoMethodBasedSyntax()
        //{

        //    //Fonte de dados
        //    int[] numeros = { 90, 71, 82, 93, 75, 82 };

        //    //Expressão de Consulta (Query Expression)
        //    IEnumerable<int> consulta = numeros.Where(consulta => numeros > 80);

        //    foreach (int resultado in consulta)
        //    {
        //        Console.WriteLine(resultado);
        //    }

        //}


    }
}
