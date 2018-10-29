using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34___LINQ_2
{
    class Exemplo4
    {
        public static void Implicitl_Typed_Local()
        {
            #region declaração Normal

            int contador = 0;
            string Nome = "Macoratti";
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> inteiros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            #endregion


            #region Usando Implicitly typed Local Variable

            var contador2 = 0;
            var Nome2 = "Macoratti";
            var numeros2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var inteiros2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            #endregion
        }

    }
}
