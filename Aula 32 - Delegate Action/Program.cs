using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_32___Delegate_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo1.Teste();
            Exemplo2.Teste();
            Exemplo3.Teste();

            Metodo1();
            Metodo2();
            Metodo3();

            Console.ReadKey();
        }

        static void Metodo1()
        {
            Console.WriteLine("");
            Console.WriteLine("Metodo1");
            //retornar uma lista de funcionarios 
            List<Funcionario> funcionarios = Funcionario.GetFuncionarios();
            Action<Funcionario> minhaAction = new Action<Funcionario>(CalculaIdade);

            funcionarios.ForEach(minhaAction); //??????
            foreach (Funcionario funci in funcionarios)
            {
                Console.WriteLine(funci.Nome + " " + funci.Idade.ToString());
            }
        }

        static void Metodo2()
        {
            Console.WriteLine("");
            Console.WriteLine("Metodo2");

            List<Funcionario> funcionarios = Funcionario.GetFuncionarios();
            Action<Funcionario> minhaAction = CalculaIdade;

            foreach (Funcionario funci in funcionarios)
            {
                Console.WriteLine(funci.Nome + " " + funci.Idade.ToString());
            }
            //não funcionou
        }

        static void Metodo3()
        {
            Console.WriteLine("");
            Console.WriteLine("Metodo3");

            List<Funcionario> funcionarios = Funcionario.GetFuncionarios();
            Action<Funcionario> minhaAction = delegate (Funcionario funcionario)
            {
                funcionario.Idade = DateTime.Now.Year - funcionario.Nascimento.Year;
            };

            funcionarios.ForEach(minhaAction);
            foreach (Funcionario funci in funcionarios)
            {
                Console.WriteLine(funci.Nome + " " + funci.Idade.ToString());
            }
            //não funcionou
        }

        static void CalculaIdade(Funcionario funcionario)
        {
            funcionario.Idade = DateTime.Now.Year - funcionario.Nascimento.Year;
        }

    }
}
