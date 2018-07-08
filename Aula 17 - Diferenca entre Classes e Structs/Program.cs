using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17___Diferenca_entre_Classes_e_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carro fusca = new Carro("Fusca", "Verde");
            //Console.WriteLine(fusca.Descricao());
            //Console.ReadKey();

            //Carro gol = fusca;
            //Console.WriteLine(gol.Descricao());
            //Console.ReadKey();

            //Carro fiat = new Carro();
            //Console.WriteLine(fiat.Descricao());
            //Console.ReadKey();

            Carro honda = default(Carro);
            honda.Modelo = "Honda";
            honda.Cor = "Azul";
            Console.WriteLine(honda.Descricao());
            Console.ReadKey();
        }
    }

    class Teste : IModelo
    {
        public void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
