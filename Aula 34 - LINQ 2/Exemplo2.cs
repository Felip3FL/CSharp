using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34___LINQ_2
{

    class Exemplo2
    {

        public static void Teste()
        {
            #region Fluxo Normal
            List<string> nomes = new List<string>();
            nomes.Add("Felipe");
            nomes.Add("Joao");
            nomes.Add("Pamella");
            #endregion

            #region Collection Inicializers
            List<string> nomes2 = new List<string> {
                "Felipe",
                "Joao",
                "Pamella"
            };

            List<Produto> lista = new List<Produto>
            {
                new Produto{ Id = 1, Nome = "Teclado", Preco = 24.50},
                new Produto{ Id = 1, Nome = "Lapis", Preco = 1.50},
                new Produto{ Id = 1, Nome = "Mouse", Preco = 15.50}
            };

            foreach (Produto p in lista)
            {
                Console.WriteLine(p.Id + " " + p.Nome + " " + p.Preco);
            }

            #endregion



        }

        class Produto
        {
            //propriedades
            public int Id { get; set; }
            public string Nome { get; set; }
            public double Preco { get; set; }
            public double Estoque { get; set; }
        }

    }




}
