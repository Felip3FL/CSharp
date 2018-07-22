using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26___String
{
    class Exemplos
    {

        public static void ExemplosString()
        {
            /*
             * \n = nova linha
             * \t = tabulação horizontal
             * \v = tabulação vertical
             * \r = retorno
             * \f = form feed
             * \o = null
             * \' = aspas simples = '
             * \\ = uma barra = \
             * 
             */

            //Para usar endereços - 2 formas:
            string diretorio;
            diretorio = @"diretorio: c:\user\felipelima\";
            diretorio = "diretorio: c:\\user\\felipelima\\";

            string a = "NovaLinha\nNovaLinha\nNovaLinha"; 
            string b = "Tabulação\tTabulação\tTabulação";
            string c = "McDonald\'s";

            Console.WriteLine(diretorio);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine("");

        }
    }
}
