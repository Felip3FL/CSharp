using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_19___Classe_Membros_static
{
    public class Calculadora2
    {
        protected string copyright = "FL - Todos os direitos reservados.";

        private int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        protected int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }

    public class Abaco : Calculadora2
    {
        int numero1;
        int numero2;
        public Abaco()
        {
            Console.WriteLine(this.copyright);
        }

        public int Subtrair()
        {
            return base.Subtrair(numero1, numero2);
        }
    }

}
