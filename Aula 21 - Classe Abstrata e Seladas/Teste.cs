using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21___Classe_Abstrata_e_Seladas
{
    public abstract class TesteClasseAbstrata
    {

        public string nome = "Felipe";
        public void Metodo1()
        {
            Console.WriteLine("Olá");
        }
        //Método Abstract
        public abstract void Metodo2();

        public string Idade { get; set; }

    }

    public abstract class DerivadaAbstract : TesteClasseAbstrata
    {
        public override void Metodo2()
        {
            throw new NotImplementedException();
        }
        public abstract void Metodo3();
    }

    public class Derivada : TesteClasseAbstrata
    {
        public override void Metodo2()
        {
            throw new NotImplementedException();
        }
    }





}
