using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26___String
{
    class Separadores
    {

        public static void ExemplosSeparadores()
        {
            // Alguns strings separadas por espaco, virgula e substring
            string stringNumerosComEspacos = "1 3 5 7 9";
            string stringCaracteresComVirgula = "a, e, i, o, u";
            string stringNumeroComSubstring = "12KKK34KKK56KKK78KKK";

            char[] separadorEspaco = new char[] { ' ' };
            char[] separadorVirgula = new char[] { ',' };
            string[] separadorString = new string[] { "KKK" };
            string[] resultado, resultado1, resultado2;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Strings separadas por espaço :\n");
            resultado = stringNumerosComEspacos.Split(separadorEspaco, StringSplitOptions.None);
            foreach (string str in resultado)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("strings separadas por vírgulas :\n");
            resultado1 = stringCaracteresComVirgula.Split(separadorVirgula, StringSplitOptions.None);
            foreach (string str in resultado1)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("strings separadas por substrings :\n");
            resultado2 = stringNumeroComSubstring.Split(separadorString, StringSplitOptions.None);
            foreach (string str in resultado2)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("");

        }

    }
}
