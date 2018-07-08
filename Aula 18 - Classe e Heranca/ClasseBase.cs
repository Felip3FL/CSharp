using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_18___Classe_e_Heranca
{
    public class ClasseBase
    {
        public string Email { get; set; }

        //contrutor
        public ClasseBase()
        {
            Console.WriteLine("Construtor da classe base");  //2
        }

        //contrutor
        public ClasseBase(string email)
        {
            Console.WriteLine("Construtor da classe base que inicializa o email");  //2
            this.Email = email;
        }
    }

    public class ClasseDerivada : ClasseBase
    {
        public string nome = "Felipe";             // 1 
        public int idade = 90;                        // 1 
        public static string email = "felipe@felipe.com.br";  // 1

        //contrutor
        public ClasseDerivada()                       // 3
        {
            Console.WriteLine("\nConstrutor da classe derivada");
        }

        //contrutor
        public ClasseDerivada(string _nome, int _idade) //: base(email)
        {
            nome = _nome;
            idade = _idade;
        }

    }
}
