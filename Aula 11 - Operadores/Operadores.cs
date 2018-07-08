using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11___Operadores
{
    class Operadores
    {
        static void Main(string[] args)
        {
            var operadores = new Operadores();

            operadores.operadoresAritmeticos();


            Console.ReadKey();

        }

        private void operadoresAritmeticos()
        {
            //operadores aritméticos : +, -, * , / e %
            int a = 10;
            int b = 20;
            int resultado;
            resultado = a + b;
            Console.WriteLine(" Soma a+b {0} ", resultado);
            resultado = a - b;
            Console.WriteLine(" operacao a-b {0} ", resultado);
            resultado = a * b;
            Console.WriteLine(" operacao a*b {0} ", resultado);
            resultado = a / b;
            Console.WriteLine(" operacao a/b {0} ", resultado);
            resultado = a % b;
            Console.WriteLine(" operacao a%b {0} ", resultado);
            Console.WriteLine(" 10 elevado a 5 {0} ", Math.Pow(10, 5)); //Exponenciacao (X elevado a y)
            Console.WriteLine(" Raiza quadrada de 121 {0} ", Math.Sqrt(121)); //Radiciação (Raiz quadrada)

        }

        private void Atribuicao()
        {
            //Atribuição: = , += , -= , *=, /= , %=

            int salario = 1000;
            int i = 1000;
            salario += 100; // salario = salario+100
            Console.WriteLine("Operador += " + salario);
            salario -= 100; // salario = salario-100
            Console.WriteLine("Operador -= " + salario);
            salario *= 100; // salario = salario*10
            Console.WriteLine("Operador *= " + salario);
            salario /= 100;// salario = salario/100
            Console.WriteLine("Operador /= " + salario);
            salario %= 100; // salario = salario%100
            Console.WriteLine("Operador %= " + salario);
            Console.ReadKey();
            //operadores ++ e --
            i++;//i=i+1
            Console.WriteLine("Operador i++ {0} ", i);
            i--;//i=i-1
            Console.WriteLine("Operador i-- {0} ", i);


        }

        private void IncrementoDecremento()
        {
            //Incremento e decremento: ++ , --

            int valor1;
            int valor2 = 1000;
            //prefixo
            valor1 = --valor2; // primeiro incrementa depois atribui
            Console.WriteLine(" valor1  {0}", valor1);
            Console.WriteLine(" valor2  {0}", valor2);
            Console.ReadKey();
            //sufixo
            int valor3;
            int valor4 = 2000;
            valor3 = valor4--; // primeiro atribui depois incrementa
            Console.WriteLine(" valor1  {0}", valor3);
            Console.WriteLine(" valor2  {0}", valor4);
        }


        private void Relacionais()
        {
            //	Relacionais: == , > , < , <= , >= , !=

            int i, j;
#pragma warning disable CS0168 // Variable is declared but never used
            bool b1, b2;
#pragma warning restore CS0168 // Variable is declared but never used
            i = 10;
            j = 11;

            if (i < j)
                Console.WriteLine("i < j");

            if (i <= j)
            {
                Console.WriteLine("i <= j");
            }

            if (i != j) Console.WriteLine("i != j");
            if (i == j) Console.WriteLine("não será executado");
            if (i >= j) Console.WriteLine("não será executado");
            if (i > j) Console.WriteLine("não será executado");
        }


        private void Logico()
        {
            //Lógicos: && , || , ! ( & , | )

            int n, d;
            n = 10;
            d = 2;

            //d é diferente de zero e 10 % 2 tem resto igual a zero
            if (d != 0 && (n % d) == 0)
                Console.WriteLine(d + " é o fator de " + n);
            Console.ReadKey();

            d = 0; // agora definimos d igual a zero

            // Como d é zero o segundo termo não é avaliado
            if (d != 0 && (n % d) == 0)
                Console.WriteLine(d + " é o fator de  " + n);
            else
                Console.WriteLine("Não avaliou o segundo termo");
            Console.ReadKey();

            // Agora vamos usar o operador & 
            // Vai ocorrer uma divisão por zero pois o segundo termo será avaliado ( n % d )
            if (d != 0 & (n % d) == 0)
                Console.WriteLine(d + " é o fator de " + n);
            else
                Console.WriteLine("Avaliou o segundo termo e causou uma divisão por zero " +
                    " Não vai executar pois não tratamos o erro)");
        }


        private void Ternario()
        {
            //Ternário : ?: (condição ? expressão1: expressão2)

            Console.WriteLine("Informe o sexo: M ou F ");
            string sexo = Console.ReadLine();

            Console.WriteLine(sexo == "M" ? "Masculino" : "Feminino");
        }

    }
}
