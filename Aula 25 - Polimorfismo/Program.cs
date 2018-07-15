using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_25___Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");

            Calcular calc = new Calcular();
            Console.WriteLine("Somando dois numeros : " + calc.Somar(10, 10));
            Console.WriteLine("Somando tres numeros : " + calc.Somar(10, 10, 10));

            //////////////////////////////////

            Console.WriteLine("");

            Veiculo[] veiculo = new Veiculo[2];

            veiculo[0] = new Automovel("GOL");
            veiculo[1] = new Aeronave("Tucano");

            MovimentarVeiculo(veiculo[0]);
            MovimentarVeiculo(veiculo[1]);

            //////////////////////////////////

            Console.WriteLine("");

            IVeiculo gol = new Automovel2("GOL");
            IVeiculo tucano = new Aeronave2("TUCANO");

            Console.WriteLine(gol.Mover());
            Console.WriteLine(tucano.Mover());

            //////////////////////////////////



            Console.ReadKey();
        }

        public static void MovimentarVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.Tipo);
            veiculo.Mover();
        }

    }
}
