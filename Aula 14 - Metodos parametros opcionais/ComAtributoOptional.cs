using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15___Metodos_parametros_opcionais
{
    class ComAtributoOptional
    {

        public void Somar(int n1, int n2, [Optional] int[] numeros )
        {
            int resultado = n1 + n2;
            if (numeros != null)
            {
                foreach (int i in numeros)
                {
                    resultado += i;
                }
            }
            System.Console.WriteLine("Soma = " + resultado);
        }

    }
}
