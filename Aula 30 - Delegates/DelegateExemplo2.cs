using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula_30___Delegates
{
    public class DelegateExemplo2
    {
        static FileStream fs;
        static StreamWriter sw;

        //declarar delegate
        public delegate void ImprimirTexto(string texto);

        //imprimir no console
        public static void ImprimeNoConsole(string texto)
        {
            Console.WriteLine(texto);
        }

        //imprime em arquivo
        public static void ImprimeEmArquivo(string texto)
        {
            fs = new FileStream(@"C:\Users\fl\Desktop\audio.log", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(texto);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void Teste()
        {
            //criar instancias do delegate
            ImprimirTexto it1 = ImprimeNoConsole;
            ImprimirTexto it2 = ImprimeEmArquivo;

            Console.WriteLine("Imprime no console");
            //invocar delegate
            it1("Felip3FL - no console");
            Console.WriteLine("Imprime no arquivo");
            it2("Felip3FL - no arquivo");
        }

    }
}
