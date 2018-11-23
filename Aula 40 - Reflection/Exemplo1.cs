using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aula_40___Reflection
{
    class Exemplo1
    {
        public static void Teste()
        {
            

            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            Console.WriteLine("\n");

        }

    }
}
