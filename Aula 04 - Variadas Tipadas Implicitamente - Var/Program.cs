using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04___Variadas_Tipadas_Implicitamente___Var
{
    class Program
    {
        static void Main(string[] args)
        {

            var i = 5;
            var nome = "felipe";
            var vetor = new[] { 0, 1, 2 };
            var aluno = new { Nome = "Macorrati" };
            var lista = new List<int>();

            //////////////////////////////////////////////////////////////////////////////////////////////////

            DMACLOJAEntities db = new DMACLOJAEntities();

            //aqui nessa consulta, eu sou obrigado a usar o VAR
            var consulta = from Loja in db.Loja
                           where Loja.LO_Loja == "271"
                           select Loja.LO_EmaiLoja;

            foreach (var n2 in consulta)
            {
                Console.WriteLine(n2);
            }

            //aqui nessa consulta, eu não é obrigado a usar o VAR
            //porque o tipo definido no nomes, foi explicito
            string[] nomes = { "nome", "felipe" };
            var consulta2 = from nomess in nomes
                           where nome[0] == 'n'
                           select nome;

            foreach(string n in consulta2)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //Aqui o obj11 eu coloco o tipo
            classeComNomeMuitoGrande<string> obj1 = new classeComNomeMuitoGrande<string>();

            //Aqui eu coloco o VAR, e ele entende qual tipo é o objeto
            var obj2 = new classeComNomeMuitoGrande<string>();

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //Aqui é um exemplo sem usar o VAR
            //string[] Vetor = { "Nome", "Felipe" };
            //IEnumerable<Felipe> obj = from x in Vetor
            //                          where x.Length > 5
            //                          select new Felipe { tamanho = x.Length, valor = x };


            //Aqui é um exemplo USANDO VAR
            string[] Vetor = { "Nome", "Felipe" };
            var obj = from x in Vetor
                      where x.Length > 5
                      select new { tamanho = x.Length, valor = x };


        }
    }

    //class Felipe
    //{
    //    public int tamanho;
    //    public string valor;
    //}

    class classeComNomeMuitoGrande<t>
    { }

}
