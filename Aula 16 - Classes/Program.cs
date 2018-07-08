using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16___Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro gol; //Definir uma variavel
            gol = new Carro("Prata Preto Branco"); //Instancia da classe com valor usando o construtor

            //gol.Cor = "Prata Preto Branco";

            Console.WriteLine(gol.Descricao());


            //Usando o STATIC para contar os carros

            CarroComStatic fusca = new CarroComStatic();
            fusca.Cor = "Vermelho";
            Console.WriteLine(fusca.Descricao());

            CarroComStatic palio = new CarroComStatic();
            palio.Cor = "Verde";
            Console.WriteLine(palio.Descricao());

            Console.WriteLine("Quantidade = " + CarroComStatic.quantidade);

            Console.ReadKey();

        }

       
    }
}
