using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21___Classe_Abstrata_e_Seladas
{
    class Program
    {
        static void Main(string[] args)
        {
            //TesteClasseAbstrata t = new TesteClasseAbstrata();
            //Teste.TesteClasseAbstrata();

            //Testando a classe selada
            //ClassesSeladas selada = new ClassesSeladas();

            //Instanciando o derivado IRREGULAR que é uma classe SELADA
            //Irregular tri = new Irregular(42.73, 35.05);
            //tri.Descricao("Irregular");
            //Console.ReadKey();

            Circulo circ = new Circulo();
            circ.Raio = 42.86;
            Console.WriteLine("Circulo Characteristics");
            Console.WriteLine("Raio:   {0}", circ.Raio);
            Console.WriteLine("Diametro: {0}", circ.Diametro);
            Console.ReadKey();
        }
    }
}
