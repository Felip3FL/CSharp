using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17___Diferenca_entre_Classes_e_Structs
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa()
        {
            Nome = "Jose Carlos";
            Sobrenome = "Macoratti";
        }
        public Pessoa(string _nome, string _sobrenome)
        {
            Nome = _nome;
            Sobrenome = _sobrenome;
        }
        protected void NomeCompleto()
        {
            Console.WriteLine(Nome + " " + Sobrenome);
        }
    }
}
