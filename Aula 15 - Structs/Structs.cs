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

            //Usando Structs com construtor
            StructsComConstrutor structsComConstrutor = new StructsComConstrutor();
            structsComConstrutor.UsandoConstrutor();

            Pessoa[] dadosPessoa = new Pessoa[3];
            int i = 0;
            do
            {

                Console.WriteLine("Informe a sua altura em metros");
                dadosPessoa[i].Altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe seu peso");
                dadosPessoa[i].Peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("O seu peso é {0} m e sua altura é {1} m", dadosPessoa[i].Altura, dadosPessoa[i].Peso);
                dadosPessoa[i].IMC = calculaIMC(dadosPessoa[i].Peso, dadosPessoa[i].Altura);

                Console.WriteLine("Seu IMC é igual á {0}", dadosPessoa[i].IMC);
                exibeResultado(dadosPessoa[i].IMC);

                i++;
            }

            while (i < dadosPessoa.Length);

            //Percorrendo o vetor e imprimindo dados
            for (int x = 0; x < dadosPessoa.Length; x++)
            {
                
                Console.WriteLine("Altura: {0}\tPeso: {1}\tIMC: {2}\n", 
                    dadosPessoa[x].Altura, dadosPessoa[x].Peso, dadosPessoa[x].IMC);
            }


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
