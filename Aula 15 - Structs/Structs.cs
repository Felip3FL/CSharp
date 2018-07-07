using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15___Structs
{
    class Structs
    {

        public struct Pessoa
        {
            public double Altura;
            public double Peso;
            public double IMC;
        }

        static void Main(string[] args)
        {

            Pessoa felipe = new Pessoa();

            Console.WriteLine("Informe a sua altura em metros");
            felipe.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe seu peso");
            felipe.Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O seu peso é {0} m e sua altura é {1} m", felipe.Altura, felipe.Peso);
            felipe.IMC = calculaIMC(felipe.Peso, felipe.Altura);

            Console.WriteLine("Seu IMC é igual á {0}", felipe.IMC);
            exibeResultado(felipe.IMC);

            Console.ReadKey();

        }

        static double calculaIMC(double peso, double altura)
        {
            //Calculo do IMC onde IMC = peso / altura * altura
            return peso / (Math.Pow(altura, 2));
        }

        static void exibeResultado(double imc)
        {
            if (imc < 18.5)
            {
                Console.WriteLine("Você esta ABAIXO do peso");
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("Seu peso esta NORMAL");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Você esta ACIMA do peso");
            }
            else if (imc > 30)
            {
                Console.WriteLine("Você esta OBESO");
            }
        }



    }
}
