using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula_26___String
{
    class MaiusculoMinusculo
    {

        public static void TesteMaiusculoMinusculo()
        {
            string texto1 = "testando esta string";
            Console.WriteLine("Usando LowerCase e UpperCase sem Globalization");
            //Converte string para uppercase
            Console.WriteLine("ToUpper : " + texto1.ToUpper());
            //Converte string para lowercase
            Console.WriteLine("ToLower : " + texto1.ToLower());

            string texto2 = "TESte";
            Console.WriteLine(" -------- Usando LowerCase e UpperCase COM Globalization ---------");
            //Cria um TextInfo basedo na cultura "en-US".
            TextInfo macorattiTextInfo = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine("ToTitleCase: " + macorattiTextInfo.ToTitleCase(texto2));
            Console.WriteLine("ToTitleCase (ToLower) :  " + macorattiTextInfo.ToTitleCase(texto2.ToLower()));
            Console.WriteLine("ToUpper : " + macorattiTextInfo.ToUpper(texto2));
            Console.WriteLine("ToLower : " + macorattiTextInfo.ToLower(texto2));
            Console.WriteLine("");
        }

    }
}
