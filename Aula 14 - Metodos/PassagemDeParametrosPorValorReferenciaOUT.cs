using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14___Metodos
{
    class PassagemDeParametrosPorValorReferenciaOUT
    {

        static void CalculaValor_PorValor(int valor)
        {
            valor = valor + 1;
        }

        public void PorValor()
        {
            int numero = 500;

            Console.WriteLine("[CalculaValor_PorValor] Valor original de numero {0}", numero);
            CalculaValor_PorValor(numero);
            Console.WriteLine("Valor após chamar o método {0}", numero);
        }


        static void CalculaValor_PorReferencia(ref int valor)
        {
            valor = valor + 1;
        }

        public void PorReferencia()
        {
            int numero = 500;

            Console.WriteLine("[CalculaValor_PorReferencia] Valor original de numero {0}", numero);
            CalculaValor_PorReferencia(ref numero);
            Console.WriteLine("Valor após chamar o método {0}", numero);

        }

        static void CalculaValor_PorReferencia_Out(out int valor)
        {
            valor = 5;
            valor = valor + 1;
        }

        public void PorReferencia_Out()
        {

            int numero = 500;

            Console.WriteLine("[CalculaValor_PorReferencia_Out] Valor original de numero {0}", numero);
            CalculaValor_PorReferencia_Out(out numero);
            Console.WriteLine("Valor após chamar o método {0}", numero);
        }


    }
}
