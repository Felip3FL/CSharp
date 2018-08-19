using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula_34___LINQ
{
    class Exemplo4
    {
        public static void Teste()
        {
            Console.WriteLine("");
            Console.WriteLine("Exemplo 4");

            var arquivos = from arquivo in new DirectoryInfo(@"C:\").GetFiles()
                           orderby arquivo.CreationTime
                           where arquivo.Name.Contains(".log")
                           select arquivo;

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine("{0}: {1}", arquivo.CreationTime, arquivo.Name);
            }

        }
    }

}
