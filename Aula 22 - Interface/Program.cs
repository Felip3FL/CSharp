using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_22___Interface
{

    class Program 
    {
      
        static void Main(string[] args)
        {

            Transacao t1 = new Transacao("001", "1/4/2015", 78900.00);
            Transacao t2 = new Transacao("002", "3/5/2015", 45900.00);
            t1.exibirTransacao();
            Console.WriteLine("-------------------------");
            t2.exibirTransacao();


            Console.ReadKey();


        }

      
    }
}
