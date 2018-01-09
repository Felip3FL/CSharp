using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___Enum
{
    class ExEnum
    {

        private enum EstadoCivil { Casado, Solteiro, Viuvo, Divorciado }
        enum DiaSemana {Seg, Ter, Qua, Qui, Sex, Sab, Dom }
        enum DiaMes : byte {Jan, Fev, Mar, Abr, Mai, Jun, Jul, Ago, Set, Out, Nov, Dez }

        enum Estado
        {
            Desligao = 0,
            Ligado = 5,
            Repouso = 10,
            Processando = Ligado + 10
        }

        static void Main(string[] args)
        {
            var testeComEnum = new ExEnum();

            testeComEnum.ExemploDiaSemana();
            testeComEnum.ExemploExibindoNome();
            testeComEnum.ExemploObterValoresEnum();
            testeComEnum.ExemploEstadoCivil(EstadoCivil.Solteiro);

            Console.ReadKey();
            Console.ReadKey();

        }

        private void ExemploExibindoNome()
        {

            //Obter o nome do Enum
            string s = Enum.GetName(typeof(DiaSemana), 4);

            Console.WriteLine("Nome do Enum DiaSemana na posição 4: " + s);

        }

        private void ExemploObterValoresEnum()
        {

            //Obter o valor do Enum

            string s = Enum.GetName(typeof(DiaSemana), 4);

            Console.WriteLine("Os valores da enumeração (GetValues) DiaSemana são: \n");
            foreach (int i in Enum.GetValues(typeof(DiaSemana)))
                Console.Write(i);

            Console.WriteLine("Os nomes da enumeração (GetValues) DiaSemana são: \n");
            foreach (string str in Enum.GetNames(typeof(DiaSemana)))
                Console.Write(str + " ");

        }

        private void ExemploDiaSemana()
        {
            DiaSemana dia = DiaSemana.Dom;
            int x = (int)DiaSemana.Dom;

            Console.WriteLine("Hoje é dia: " + dia);
            Console.WriteLine("Enum: " + x);
        }


        private void ExemploEstadoCivil(EstadoCivil s)
        {
            Console.WriteLine("\nExemploEstadoCivil\n");

            switch (s)
            {
                case EstadoCivil.Solteiro:
                    Console.WriteLine("\nSolteiro\n");
                    break;
                case EstadoCivil.Casado:
                    Console.WriteLine("\nCasado\n");
                    break;
                case EstadoCivil.Viuvo:
                    Console.WriteLine("\nViúvo\n");
                    break;
                case EstadoCivil.Divorciado:
                    Console.WriteLine("\nDivorciado\n");
                    break;
                default:
                    throw new Exception("O valor informado esta fora do escopo da Enumeration");
            }
        }

    }

}
