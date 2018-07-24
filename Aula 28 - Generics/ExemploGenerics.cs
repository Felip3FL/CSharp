using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28___Generics
{
    class ExemploGenerics
    {
        public static void ExemplosDeArrayColecao()
        {
            //arrays
            string[] nomes = new string[2];
            nomes[0] = "Felip3FL";
            Console.WriteLine(nomes[0]);
            //nomes[1] = 100;

            //colecoes
            ArrayList colecao = new ArrayList();
            colecao.Add("FELIPE");  //Tipo String
            colecao.Add(100);       //Tipo numerico

            int valor = (int)colecao[1];
            Console.WriteLine(valor);


            Console.WriteLine("");
        }

        public static void ExemploListaGenerica()
        {
            // List<T> nome = new List<t>();
            List<string> lista1 = new List<string>();
            List<int> lista2 = new List<int>();
            lista1.Add("GENERICA");
            lista2.Add(100);

            Console.WriteLine("");
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente(string _nome)
        {
            Nome = _nome;
        }
    }

}
