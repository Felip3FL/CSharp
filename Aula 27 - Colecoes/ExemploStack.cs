using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27___Colecoes
{
    class ExemploStack
    {
        public static void ExemploDeStack()
        {
            Stack pilha = new Stack();
            pilha.Push("Felipe");
            pilha.Push("felipe.com.br");
            pilha.Push("C-Sharp");

            Console.WriteLine("Tamanho da pilha " + pilha.Count);
            while (pilha.Count > 0)
                Console.WriteLine(pilha.Pop());
            Console.ReadLine();
        }
    }
}
