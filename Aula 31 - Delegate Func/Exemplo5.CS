using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31___Delegate_Func
{
    class Exemplo5
    {
        public static void Teste()
        {
            //usando metodo anônimo 
            Func<string, string> ConverteDelegate = delegate (string palavra)
            {
                return palavra.ToUpper();
            };
            
            Console.WriteLine(ConverteDelegate("felipe"));
        }

        //private static string CaixaAlta(string texto)
        //{
        //    return texto.ToUpper();
        //}
    }
}
