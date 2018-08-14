using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_32___Delegate_Action
{
    class Funcionario
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public int Idade { get; set; }

        public static List<Funcionario> GetFuncionarios()
        {
            return new List<Funcionario>()
            {
                new Funcionario()
                {
                    Nome = "Felipe",
                    Nascimento = Convert.ToDateTime("1958/08/13")
                },
                new Funcionario()
                {
                    Nome = "Joao",
                    Nascimento = Convert.ToDateTime("1968/08/13")
                },
                new Funcionario()
                {
                    Nome = "Pedro",
                    Nascimento = Convert.ToDateTime("1978/08/13")
                }
            };
        }

    }
}
