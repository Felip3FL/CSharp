using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_19___Classe_Membros_static
{
    public class Teste
    {
        static int a = 0;
        int b = 0;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }
    }
}
