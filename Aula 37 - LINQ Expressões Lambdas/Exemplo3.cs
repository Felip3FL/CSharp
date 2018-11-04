using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_37___LINQ_Expressões_Lambdas
{
    class Exemplo3
    {
        public static void Teste1()
        {

            Console.Write("\n\nExpresssão LAMBDA usando DELEGATE FUNC\n");

            //Func<Aluno, string> verificaNome = aluno =>
            //{
            //    if (aluno.Nome.StartsWith("J"))
            //        return aluno.Nome;
            //    else
            //        return "O Aluno não atende o critério.";
            //};

            Func<Aluno, string> verificaNome = aluno => aluno.Nome.StartsWith("J") ? aluno.Nome : "O Aluno não atende o critério.";

            //Criando pessoa em tempo de execução:
            Console.WriteLine(verificaNome(new Aluno() { Id = 12, Nome = "Felipe" }));
            Console.WriteLine(verificaNome(new Aluno() { Id = 10, Nome = "Jefferson" }));
            Console.WriteLine(verificaNome(new Aluno() { Id = 7, Nome = "Janice" }));
        }
    }

    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

}
