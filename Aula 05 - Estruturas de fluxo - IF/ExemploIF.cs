using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05___Estruturas_de_fluxo___IF
{
    class ExemploIF
    {
        static void Main(string[] args)
        {

            bool a = true, b = false;
            if (a) if (b) System.Console.WriteLine("a e b são true"); else System.Console.WriteLine("a é true e b é false");
            else System.Console.WriteLine("a é false");


            if (a)
            {
                if (b)
                {
                    System.Console.WriteLine("a e b são true");
                }
                else
                {
                    System.Console.WriteLine("a é true e b é false");
                }
            }
            else
            {
                System.Console.WriteLine("a é false");
            }

            System.Console.ReadKey();

        }
    }
}
