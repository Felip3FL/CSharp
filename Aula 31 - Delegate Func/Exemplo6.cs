using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31___Delegate_Func
{
    class Exemplo6
    {
        public static void Teste()
        {
            //usando metodo lambda 
            Func<string, string> ConverteDelegate = str => str.ToUpper();

            Console.WriteLine(ConverteDelegate("felipe"));
        }
    }
}
