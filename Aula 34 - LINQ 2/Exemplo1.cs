using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34___LINQ_2
{
    class Exemplo1
    {
        public static void Teste()
        {
            Console.WriteLine("");
            Console.WriteLine("Exemplo 1");

            #region Fluxo Normal
            Produto p1 = new Produto();
            p1.Id = 1;
            p1.Nome = "Lapis";
            p1.Preco = 1.45;
            #endregion

            #region Fluxo com Object Initializers
            Produto p2 = new Produto {Id = 2,Nome = "Borracha",Preco=1.07};
            #endregion

            Console.WriteLine(p2.Id);
            Console.WriteLine(p2.Nome);
            Console.WriteLine(p2.Preco);
        }

        class Produto
        {
            public string Promocao;
            public int Id { get; set; }
            public string Nome { get; set; }
            public double Preco { get; set; }
        }

    }
}
