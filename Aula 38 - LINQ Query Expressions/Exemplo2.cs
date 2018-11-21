using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_38___LINQ_Query_Expressions
{
    class Exemplo2
    {

        public static void ExemploPedidoCliente()
        {

            Console.WriteLine("\n");

            //cliente
            //pedidos
            //onde um cliente pode ter muitos pedidos
            //relacionamento entre as classes do tipo um-para-minutos cliente --- pedido

            List<Cliente> clientes = new List<Cliente>();

            Cliente cliente1 = new Cliente()
            {
                NomeCliente = "Felipe",
                Pedidos = new List<Pedido>()
                {
                    new Pedido() {NomePedido="Pizza",Quantidade=5},
                    new Pedido() {NomePedido="Frango",Quantidade=3},
                    new Pedido() {NomePedido="Salada",Quantidade=2}
                }
            };

            Cliente cliente2 = new Cliente()
            {
                NomeCliente = "Pamella",
                Pedidos = new List<Pedido>()
                {
                    new Pedido() {NomePedido="Refrigerante",Quantidade=4},
                    new Pedido() {NomePedido="Lazanha",Quantidade=2},
                    new Pedido() {NomePedido="Batata",Quantidade=2},
                    new Pedido() {NomePedido="Salada",Quantidade=3}
                }
            };

            clientes.Add(cliente1);
            clientes.Add(cliente2);


            //Consulta
            var resultado = from cli in clientes
                            from ped in cli.Pedidos
                            select new
                            {
                                cli.NomeCliente,
                                ped.NomePedido,
                                ped.Quantidade
                            };

            foreach(var res in resultado)
            {
                Console.WriteLine("Nome: {0}, Pedido {1}, Quantidade {2}",
                    res.NomeCliente,res.NomePedido,res.Quantidade);
            }

        }


    }
}
