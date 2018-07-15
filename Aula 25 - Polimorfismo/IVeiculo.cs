using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_25___Polimorfismo
{
    public interface IVeiculo
    {
        string Mover();
    }

    public class Automovel2 : IVeiculo
    {
        public string Tipo { get; set; }
        public Automovel2(string modelo)
        {
            Tipo = modelo;
        }
        public string Mover()
        {
            return "Acelerando o Automovel : " + Tipo;
        }
    }

    public class Aeronave2 : IVeiculo
    {
        public string Tipo { get; set; }
        public Aeronave2(string modelo)
        {
            Tipo = modelo;
        }
        public string Mover()
        {
            return "Decolando a aeronave : " + Tipo;
        }
    }

}
