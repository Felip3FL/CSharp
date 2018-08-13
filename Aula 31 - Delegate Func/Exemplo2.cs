﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31___Delegate_Func
{
    class Exemplo2
    {
        //static private long Multiplicar(int n1, int n2, int n3)
        //{
        //    return n1 * n2 * n3;
        //}

        public static void Teste()
        {
            Func<int, int, int, long> delMult = delegate (int a, int b, int c)
            {
                return a * b * c;
            };

            Console.WriteLine(delMult(2, 3, 5));
        }

    }
}
