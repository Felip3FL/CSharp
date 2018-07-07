using Aula_15___Metodos_parametros_opcionais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14___Metodos_parametros_opcionais
{
    class Principal
    {
        static void Main(string[] args)
        {

            ////////////////////////////////////////////////////

            Console.WriteLine("ComSobrecarga");
            ComSobrecarga sobrecarga = new ComSobrecarga();
            //Aqui estou chamando o Somar 2, usando o metodo de sobrecarga
            sobrecarga.Somar(10, 20);
            //Aqui estou chamando o Somar 1
            sobrecarga.Somar(10, 20, new int[] {30,40,50});

            ////////////////////////////////////////////////////

            Console.WriteLine("ComParams");
            ComParams comParams = new ComParams();
            comParams.Somar(10, 20, 30, 40, 50);

            ////////////////////////////////////////////////////

            Console.WriteLine("comEspecificaValor");
            ComEspecificaValor comEspecificaValor = new ComEspecificaValor();
            comEspecificaValor.Somar(10,20);
            comEspecificaValor.Somar(10, 20, new int[] { 30, 40, 50 });

            ////////////////////////////////////////////////////

            Console.WriteLine("ComAtributoOptional");
            ComAtributoOptional comAtributoOptional = new ComAtributoOptional();
            comAtributoOptional.Somar(10, 20);
            comAtributoOptional.Somar(10, 20, new int[] { 30, 40, 50 });


            Console.ReadKey();

        }


    }
}
