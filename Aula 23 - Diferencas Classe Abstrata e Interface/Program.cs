using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23___Diferencas_Classe_Abstrata_e_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente c = new Cliente();
            Cliente3 c3 = new Cliente3();

        }





        public class Cliente : Pessoa
        {
            public override int calcularIdade(int idade)
            {
                throw new NotImplementedException();
            }
            //Os demais métodos, (Imprimir, por exemplo), serão herdados
        }


        public class Cliente2 : IPessoa
        {
            public string Versao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int calcularIdade(int idade)
            {
                throw new NotImplementedException();
            }

            public void exibirGenero()
            {
                throw new NotImplementedException();
            }

            public void Imprimir(string texto)
            {
                throw new NotImplementedException();
            }
        }



        public class Cliente3 : Pessoa, IPessoa
        {
            public override int calcularIdade(int idade)
            {
                throw new NotImplementedException();
            }

            public void exibirGenero()
            {
                throw new NotImplementedException();
            }
        }

        public abstract class Pessoa
        {
            public string nome;
            protected string codigo;

            public string Versao { get; set; }

            public void Imprimir(string texto)
            {
                Console.WriteLine(texto);
            }

            public abstract int calcularIdade(int idade);

        }

        public interface IPessoa
        {
            //ERRO: Interfaces cannot contain fields
            //public string nome;
            //protected string codigo;

            //ERRO: The modifier 'public' is not valid for this item
            //public string Versao { get; set; }
            string Versao { get; set; }

            //ERRO: interface members cannot have a definition 
            void Imprimir(string texto);
            //{
            //Console.WriteLine(texto);
            //}

            //ERRO: The modifier 'abstract' is not valid for this item
            //abstract int calcularIdade(int idade);
            int calcularIdade(int idade);
            void exibirGenero();
        }

        public class Cliente10 : IPessoa
        {
            public string Versao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int calcularIdade(int idade)
            {
                throw new NotImplementedException();
            }

            public void exibirGenero()
            {
                throw new NotImplementedException();
            }

            public void Imprimir(string texto)
            {
                throw new NotImplementedException();
            }
        }

        public class Aluno : IPessoa
        {
            public string Versao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int calcularIdade(int idade)
            {
                throw new NotImplementedException();
            }

            public void exibirGenero()
            {
                throw new NotImplementedException();
            }

            public void Imprimir(string texto)
            {
                throw new NotImplementedException();
            }
        }

    }
}

