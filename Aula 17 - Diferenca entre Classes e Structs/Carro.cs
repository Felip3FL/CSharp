using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17___Diferenca_entre_Classes_e_Structs
{

    public struct Carro
    {
        public string cor;
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public Carro(string modelo, string cor)
        {
            this.modelo = modelo;
            this.cor = cor;
        }

        public string Descricao()
        {
            return "Carro :" + Modelo + " Cor : " + Cor;
        }
    }


}
