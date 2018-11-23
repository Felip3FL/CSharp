using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aula_40___Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo1.Teste();

            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            foreach(var type in types)
            {
                Console.WriteLine("[Type]" + type.Name + "   [Tipo Base]" + type.BaseType);

                var props = type.GetProperties();
                foreach(var prop in props)
                {
                    Console.WriteLine("\t[Propriedade]" + prop.Name + "   [Tipo]" + prop.PropertyType);
                }

                var fields = type.GetFields();
                foreach(var field in fields)
                {
                    Console.WriteLine("\t[Field]" + field.Name);
                }

                var metodos = type.GetMethods();
                foreach (var metodo in metodos)
                {
                    Console.WriteLine("\t[metodo]" + metodo.Name);
                }

            }

            var teste = new Teste() { Nome = "Felipe", Idade = 26 };
            var testeTipo = typeof(Teste);
            var propriedadeNome = testeTipo.GetProperty("Nome");
            Console.WriteLine("\n\nValor da propriuedade Nome: " + propriedadeNome.GetValue(teste));


            //Invocando um metodo
            var meuMetodo = testeTipo.GetMethod("Mensagem");
            meuMetodo.Invoke(teste, null);

            Console.ReadKey();

        }
    }
}
