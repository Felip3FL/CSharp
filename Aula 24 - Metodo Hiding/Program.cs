using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_24___Metodo_Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro wolf = new Cachorro();
            wolf.Comer();
            Console.ReadKey();
        }
    }


    public class Animal
    {
        public virtual void Mover()
        {
            Console.WriteLine("Um animal se move");
        }
        public void Comer()
        {
            Console.WriteLine("Um animal come para viver");
        }
    }

    public class Cachorro : Animal
    {
        public override void Mover()
        {
            Console.WriteLine("Um cachorro se move sobre 4 patas");
        }

        //method hiding (ocultando o método Comer da classe base)
        public new void Comer()
        {
            Console.WriteLine("Um cão come ração");
            base.Comer();
        }

    }

}
