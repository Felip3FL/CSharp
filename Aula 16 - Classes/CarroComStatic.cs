using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16___Classes
{
    class CarroComStatic
    {

        public static int quantidade = 0;
        private string _cor;
        public string Cor
        {
            get { return _cor; }
            set { _cor = value; }
        }

        public CarroComStatic()
        {
            quantidade++;
        }

        public CarroComStatic(string cor)
        {
            this.Cor = cor;
        }

        public string Descricao(string texto)
        {
            return "O carro é : " + texto;
        }

        public string Descricao()
        {
            return "O carro é : " + Cor;
        }

        public static int quantosCarros()
        {
            return quantidade;
        }

    }
}
