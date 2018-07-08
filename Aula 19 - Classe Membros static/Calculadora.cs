using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_19___Classe_Membros_static
{
    public static class Calculadora
    {
        //somar
        public static int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public static int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

    }
}
