using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34___LINQ_2
{
    class Exemplo5
    {

        public static void UsandoLINQ()
        {

            Console.WriteLine("\nUsandoLINQ");

            List<Produto> listaProduto = new List<Produto> {
                new Produto
                {
                    Id=1,
                    Nome ="Caneta",
                    Preco = 1.45
                },
                new Produto
                {
                    Id=2,
                    Nome ="Lápis",
                    Preco = 1.20
                },
                new Produto
                {
                    Id=3,
                    Nome ="Borracha",
                    Preco = 0.89
                }
            };

            //Essa consulta vai retorna um tipo anônimo 
            var produtoMaiorEstoque = from produto in listaProduto
                                      where produto.Preco > 1.10
                                      select new
                                      {
                                          NomeProduto = produto.Nome,
                                          PrecoProduto = produto.Preco
                                      };

            foreach(var p in produtoMaiorEstoque)
            {
                Console.WriteLine(p.NomeProduto + "" + p.PrecoProduto);
            }

        }

        class Produto
        {
            //propriedades
            public int Id { get; set; }
            public string Nome { get; set; }
            public double Preco { get; set; }
        }

    }
}
