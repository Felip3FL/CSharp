using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07___Switch_Case
{
    class SwitchCaseEx
    {



        static void Main(string[] args)
        {

            var switchcase = new SwitchCaseEx();

            //switchcase.exemplo1();
            switchcase.Exemplo2();

            Console.ReadKey();

        }

        public enum Volume
        {
            Baixo,
            Medio,
            Alto
        }

        private void Exemplo2()
        {

            Volume volume = Volume.Medio;

            switch (volume)
            {
                case Volume.Baixo:
                    Console.WriteLine("O volume está baixo");
                    break;
                case Volume.Medio:
                    Console.WriteLine("O volume está médio");
                    break;
                case Volume.Alto:
                    Console.WriteLine("O volume está alto");
                    break;
                default:
                    Console.WriteLine("Indefinido");
                    break;
            }


        }

        private void Exemplo1()
        {
            int numero = 0;
            Console.WriteLine("Digite um número :  ");
            int.TryParse(Console.ReadLine(), out numero); //usando TryParse (Converte valor)

            switch (numero)
            {
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("Você digitou : " + numero);
                    break;

                case 15:
                    Console.WriteLine("Você digitou : " + numero);
                    break;

                case 20:
                    goto case 10;

                default:
                    Console.WriteLine("Numero inválido");
                    break;
            }


        }



    }

}

