using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_19___Classe_Membros_static
{
    class Program
    {
        static void Main(string[] args)
        {

            //////////////////////////////////////////////////////////

            Livro livro1 = new Livro();

            livro1.Titulo = "ASP, ADO Banco de dados na Web";
            livro1.Autor = "Felip3FL";

            Console.WriteLine(" Titulo : " + livro1.Titulo);
            Console.WriteLine(" Autor : " + livro1.Autor);
            Console.WriteLine("");


            Livro livro2 = new Livro();
            livro2.Titulo = "ASP .NET como Programar";
            livro2.Autor = "Felipe Lima";

            Console.WriteLine(" Titulo : " + livro2.Titulo);
            Console.WriteLine(" Autor : " + livro2.Autor);
            Console.WriteLine("");

            //////////////////////////////////////////////////////////

            //Usando os metodos SOMAR sem instanciar a classe

            Console.WriteLine("Soma= " + Calculadora.Somar(7, 2).ToString());
            Console.WriteLine("Subtração = " + Calculadora.Subtrair(7, 2).ToString());

            int resultado = Calculadora.Multiplicar(7, 2);
            Console.WriteLine("Multiplicação = " + resultado);
            Console.WriteLine("Divisão = " + Calculadora.Dividir(7, 2).ToString());

            double r = Math.Pow(2, 4);
            Console.WriteLine("Potencia = {0}", r.ToString());
            Console.WriteLine("");

            //////////////////////////////////////////////////////////

            //Mostrando que há apenas 1 códia de uma classe na memoria

            Teste t1 = new Teste();
            Teste t2 = new Teste();

            Console.WriteLine("Atribuindo t1.A = 5, t1.B = 5:");
            Console.WriteLine("");
            t1.A = 5;
            t1.B = 5;
            Console.WriteLine("t1.A = {0}, t1.B = {1}", t1.A, t1.B);
            Console.WriteLine("t2.A = {0}, t2.B = {1}", t2.A, t2.B);
            t2.A = 9;
            t2.B = 9;
            Console.WriteLine("");
            Console.WriteLine("Atribuindo t2.A = 9, t2.B = 9:");
            Console.WriteLine("");
            Console.WriteLine("t1.A = {0}, t1.B = {1}", t1.A, t1.B);
            Console.WriteLine("t2.A = {0}, t2.B = {1}", t2.A, t2.B);

            Console.WriteLine("");

            //////////////////////////////////////////////////////////

            //Testando Visibilidade ou escopo

            Calculadora2 calc = new Calculadora2();
            Abaco abaco = new Abaco();

            //////////////////////////////////////////////////////////

            Console.ReadKey();

        }
    }




}
