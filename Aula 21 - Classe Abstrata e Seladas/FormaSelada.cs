using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21___Classe_Abstrata_e_Seladas
{

    public abstract class FormaSelada
    {
        public virtual double Raio { get; set; }
        public abstract double Diametro { get; }
    }

    public class Circulo : FormaSelada
    {
        private double rad;

        public sealed override double Raio // sealed antes de  override
        {
            get
            {
                return this.rad;
            }

            set
            {
                this.rad = value;
            }
        }

        public override sealed double Diametro // override antes de sealed => são equivalentes
        {
            get
            {
                return this.rad * 2;
            }
        }
    }

    //public sealed class Esfera : Circulo
    //{
    //    private double rad;

    //    public override double Raio
    //    {
    //        get
    //        {
    //            return this.rad;
    //        }

    //        set
    //        {
    //            this.rad = value;
    //        }
    //    }
    //}


}
