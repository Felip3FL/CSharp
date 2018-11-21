using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_38___LINQ_Query_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            Exemplo1 exemplos1 = new Exemplo1();

            exemplos1.SintaxeDeConsultaQuerySyntax1();
            exemplos1.SintaxeDeConsultaQuerySyntax2();
            exemplos1.ExemploComDoisFrom();

            Exemplo2.ExemploPedidoCliente();

            Console.ReadKey();

        }
    }
}
