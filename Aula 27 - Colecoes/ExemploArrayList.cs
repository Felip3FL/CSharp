using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27___Colecoes
{
    class ExemploArrayList
    {

        public static void ExemploDeArrayList()
        {
            ArrayList bau = new ArrayList();
            bau.Add("FELIPE");
            bau.Add("2018/07/22");
            bau.Add(2013);              //int
            bau.Add("OOO");             //string
            bau.Add(null);              //null
            bau.Add(true);              //boolean
            bau.Add("####");            //string
            bau.Add(12.25);             //double
            bau.Add(14.45f);            //float

            Console.WriteLine("Array Bau");
            Console.WriteLine("capacidade = " + bau.Capacity);
            Console.WriteLine("tamanho = " + bau.Count);
            Console.WriteLine("removendo o elemento OOO");
            bau.Remove("OOO");
            Console.WriteLine("inserindo um novo elemento : the end ");
            bau.Add("The end");

            Console.WriteLine("Percorrendo o ArrayList");
            for (int indice = 0; indice < bau.Count; indice++)
            {
                Console.WriteLine("Indice {0} - {1} ", indice, bau[indice]);
            }

            Console.WriteLine("Limpando o bau");
            bau.Clear();

            if (bau.Count == 0)
            {
                Console.WriteLine("O bau está vazio . . . ");
            }

            Console.WriteLine("");

        }

    }
}
