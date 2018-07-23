using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27___Colecoes
{
    class ExemploQueue
    {

        public static void ExemploDeQueue()
        {
            Queue fila = new Queue();
            fila.Enqueue("Felipe");
            fila.Enqueue("felipe.com.br");
            fila.Enqueue("ASP NET");

            Console.WriteLine("Tamanho da fila : " + fila.Count);
            while (fila.Count > 0)
            {
                Console.WriteLine(fila.Dequeue());
            }

        }

    }
}
