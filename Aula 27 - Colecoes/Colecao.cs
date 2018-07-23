using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27___Colecoes
{
    class Colecao
    {
        public static void ExemploColecao()
        {

            //Aqui nessa array, eu só consigo armazenar STRING
            String[] nomes = new String[2];
            nomes[0] = "Felipe";
            nomes[1] = "Joao";
            Console.WriteLine("nomes[0] = " + nomes[0]);


            //Aqui nessa array, eu só consigo armazenar INT
            int[] numeros = new int[2];
            numeros[0] = 1;
            numeros[1] = 10;
            Console.WriteLine("numeros[0] = " + numeros[0]);

            //Criando uma colecao
            ArrayList colecao = new ArrayList();
            colecao.Add(nomes);     //posicao 0
            colecao.Add(numeros);   //posicao 1
            colecao.Add("FELIPE");  //posicao 2
            colecao.Add(123);       //posicao 3

            //Obs. Não definir o tipo, todos os valores acima foram aceitado

            Console.WriteLine("colecao[0] = " + colecao[0]);

            //Recuperando valor de uma string (Usando cast)
            int valor = (int)colecao[3];

            Console.WriteLine("");

        }

    }
}
