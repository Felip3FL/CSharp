using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31___Delegate_Func
{
    class Exemplo4
    {
        public static void Teste()
        {
            Func<string, string> ConverteDelegate = CaixaAlta;
            Console.WriteLine(ConverteDelegate("felipe"));
        }

        private static string CaixaAlta(string texto)
        {
            return texto.ToUpper();
        }

    }
}
