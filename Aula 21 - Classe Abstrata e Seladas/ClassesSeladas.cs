using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21___Classe_Abstrata_e_Seladas
{
    public sealed class ClassesSeladas
    {
        public void MetodoTeste1()
        {

        }
    }

    //public class DerivacaoClasseSelada : ClassesSeladas
    //{
    //    public override void MetodoTeste1()
    //    {

    //    }
    //}


    public abstract class Triangulo
    {
        private double _base;
        private double _altura;

        public Triangulo(double comprimento = 0.00D, double altura = 0.00D)
        {
            this._base = comprimento;
            this._altura = altura;
        }

        public virtual double Area()
        {
            return this._base * this._altura / 2;
        }

        public void Descricao(string tipo = "")
        {
            Console.WriteLine("Triangulo - {0}", tipo);
            Console.WriteLine("Base  : {0}", this._base);
            Console.WriteLine("Altura: {0}", this._altura);
            Console.WriteLine("Area  : {0}", this.Area());
        }
    }

    public sealed class Irregular : Triangulo
    {
        //chamando o contrutor do Triangulo:
        public Irregular(double Base, double Altura)
            : base(Base, Altura)
        {
        }
    }



}
