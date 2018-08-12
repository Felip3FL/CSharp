using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_30___Delegates
{
    class Program
    {

        //declaracao do delegate com definição dos parametros e tipo de retorno
        delegate void SimplesDelegate(string texto);

        static void Main(string[] args)
        {
            //criar instancia do delegate
            //SimplesDelegate sd = new SimplesDelegate(ImprimeTexto);
            SimplesDelegate sd1 = ImprimeTexto;
            sd1("FELIPE " + DateTime.Today.ToShortDateString());

            DelegateExemplo2.Teste();

            Console.ReadKey();

        }

        //definição do método para usar com o delegate
        //ele deve possuir a mesma assinatura do delegate
        static private void ImprimeTexto(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
