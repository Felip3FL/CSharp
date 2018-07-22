using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26___String
{
    class Metodos
    {

        public static void MetodosString()
        {
            string f = "Felipe";
            Console.WriteLine(f);

            
            Console.WriteLine(f.Replace("a", "+"));
            Console.WriteLine(f.Insert(0, "FELIPE"));
            Console.WriteLine(f.Remove(0, 3));
            Console.WriteLine(f.Substring(0, 3));
            Console.WriteLine(f.ToUpper());
            Console.WriteLine(f.ToLower());
            Console.WriteLine(f.IndexOf("t"));

            Console.WriteLine("");

        }

    }
}
