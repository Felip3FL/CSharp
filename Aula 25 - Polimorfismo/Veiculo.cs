using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_25___Polimorfismo
{

    public class Veiculo
    {
        private string tipo;
        public string Tipo { get; set; }

        public Veiculo(string tipo)
        {
            this.Tipo = tipo;
        }

        //Estou indicando que MOVER() pode ser sobreescrito
        public virtual void Mover()
        { }
    }

    public class Automovel : Veiculo
    {
        public Automovel(string tipo)
            : base(tipo)
        { }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o veiculo");
        }
    }

    public class Aeronave : Veiculo
    {
        public Aeronave(string tipo)
            : base(tipo)
        { }

        //Sobreescrever usando OVERRIDE
        public override void Mover()
        {
            Console.WriteLine("Decolando a aeronave");
        }
    }

}
