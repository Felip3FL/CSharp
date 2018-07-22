using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26___String
{
    class JuntarStrings
    {

        public static void ExemploJuntaString()
        {
            //Adicionando strings usando o operador + 
            Console.WriteLine("Adicionando strings usando o operador + ");
            string str0 = "Jose";
            string str1 = "Carlos";
            string str2 = str0 + " " + str1 + " " + "Macoratti";
            Console.WriteLine(str2);

            //Adicionando o string usando o operador += 
            Console.WriteLine("Adicionando o string usando o operador += ");
            string str3 = "Jose";
            string str4 = "Carlos";
            string str5 = "Macoratti";
            str3 += " " + str4 + " " + str5;
            Console.WriteLine(str3);

            //Adicionando o string usando o método string.Concat()
            Console.WriteLine("Adicionando o string usando o método string.Concat()");
            string str6 = "Jose";
            string str7 = "Carlos";
            string str8 = string.Concat(str6, " ", str7, " ", "Macoratti");
            Console.WriteLine(str8);

            //Copiando strings
            string str9 = "Macoratti";
            string strResultado = String.Copy(str9);
            Console.WriteLine("Método Copy resultado :" + strResultado);
            Console.WriteLine("");
        }

    }
}
