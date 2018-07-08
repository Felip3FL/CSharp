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
            gol = new Carro(); //Instancia da classe, cria o objeto

            gol.Cor = "Prata Preto Branco";


            Console.WriteLine(gol.Descricao());
            Console.ReadKey();

        }

       
    }
}
