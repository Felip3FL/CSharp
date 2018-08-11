using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_29___Partial_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            ArquivoFisico arquivoFisicoJuntos = new ArquivoFisico("TESTE");

            Console.WriteLine(arquivoFisicoJuntos.Metodo1());
            Console.WriteLine(arquivoFisicoJuntos.Metodo2());
            Console.ReadKey();
        }
    }
}
