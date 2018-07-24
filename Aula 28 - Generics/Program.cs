using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28___Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploGenerics.ExemplosDeArrayColecao();
            ExemploGenerics.ExemploListaGenerica();

            //Criando uma lista de clientes
            List<Cliente> cliente = new List<Cliente>();
            cliente.Add(new Cliente("NOVO CLIENTE"));

            Console.ReadKey();

        }
    }
}
