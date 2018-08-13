using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31___Delegate_Func
{
    class Exemplo3
    {
        public static void Teste()
        {
            //expressão lambda
            Func<int, int, int, long> delMult = (a,b,c) =>
            {
                return a * b * c;
            };

            Console.WriteLine(delMult(2, 3, 5));
        }
    }
}
