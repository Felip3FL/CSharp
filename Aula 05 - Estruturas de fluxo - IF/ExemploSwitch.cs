using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05___Estruturas_de_fluxo___IF
{
    class ExemploSwitch
    {
        public void Exemplo()
        {

            int numero = 1;
            switch (numero)
            {
                case 0:
                    Console.WriteLine("O número é zero");
                    break;
                case 2 - 1:
                    Console.WriteLine("O número é 1!");
                    break;
            }

            System.Console.ReadKey();

        }
    }
}
