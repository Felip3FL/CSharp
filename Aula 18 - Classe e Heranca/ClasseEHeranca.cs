using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_18___Classe_e_Heranca
{
    class ClasseEHeranca
    {
        static void Main(string[] args)
        {

            PessoaFisica felipe = new PessoaFisica();

            felipe.nome = "Felipe";
            felipe.endereço = "Rua 10";
            felipe.rg = "66.666.666-66";
            felipe.cpf = "666.666.666-66";
            felipe.TesteOcutarMembros();

            //Aluno joao = new Aluno()
            //joao.nome = "Felipe";
            //joao.endereço = "Rua 10";
            //joao.rg = "66.666.666-66";
            //joao.cpf = "666.666.666-66";
            //joao.matricula = "RA00000";

            Console.WriteLine("");

            //Para Acessar um membro oculto  
            PessoaFisica pedroPessoaFisica = new PessoaFisica();
            Pessoa pedro = (PessoaFisica)pedroPessoaFisica;

            pedroPessoaFisica.TesteOcutarMembros();
            pedro.TesteOcutarMembros();
            Console.WriteLine("");



            //Sobrescrever metodo
            PessoaFisica2 maria = new PessoaFisica2();
            maria.rg = "va";
            maria.cpf = "va";
            maria.nome = "va";
            maria.endereço = "va";
            maria.TesteSobreEscrever();
            Console.WriteLine("");


            //Chamando certo construtor 
            ClasseDerivada derivado = new ClasseDerivada("Felipe",90);
            Console.WriteLine("Criei uma instância da classe derivada");
            Console.WriteLine("nome : " + derivado.nome);
            Console.WriteLine("idade : " + derivado.idade);
            Console.WriteLine("Email : " + derivado.Email);
            Console.WriteLine("");


            Console.ReadKey();

        }
    }
}
