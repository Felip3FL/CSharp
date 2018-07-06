using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_14___Metodos;

namespace Aula_14___Metodos
{
    class ProcedimentosFuncoes
    {


        //PROCEDIMENTO
        static void Teste()
        {
            Console.WriteLine("Aqui não retorna nenhum valor");
        }

        //FUNÇÃO
        static int Soma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("ProcedimentosFuncoesParametros");
            PassagemDeParametrosPorValorReferenciaOUT metodo = new PassagemDeParametrosPorValorReferenciaOUT();

            metodo.PorValor();
            metodo.PorReferencia();
            metodo.PorReferencia_Out();

            Console.ReadKey();

        }
    }
}
