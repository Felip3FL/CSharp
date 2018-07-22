using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26___String
{
    class Comparacao
    {

        public static void ExemploComparacao()
        {
            string a = "Felipe";
            string b = "Felipe";

            Console.WriteLine("Compara {0} com {1} se é igual", a,b);

            if (a == b)
                Console.WriteLine("É igual");
            else
                Console.WriteLine("É diferente");

            Console.WriteLine("");

        }


    }
}
