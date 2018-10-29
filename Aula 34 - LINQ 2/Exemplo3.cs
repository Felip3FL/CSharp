using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34___LINQ_2
{
    class Exemplo3
    {
        public static void Anonymous_Type()
        {
            var produto1 = new { Id = 1, Nome = "Caneta", Preco = 1.25 };

            Console.WriteLine("\nAnonymous_Type");
            Console.WriteLine("Produto -");
            Console.WriteLine(produto1.Id);
            Console.WriteLine(produto1.Nome);
            Console.WriteLine(produto1.Preco);
 
        }
    }
}
