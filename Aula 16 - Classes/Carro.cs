using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16___Classes
{


    class Carro
    {

        //Construtor
        public Carro(String cor)
        {
            this.Cor = cor;
        }

        //Sobrecarregando construtor
        public Carro()
        {

        }

        private string cor;

        public string Cor
        {
            get { return cor; }
            set
            {
                if (value.Contains("Prata Preto Branco"))
                {
                    cor = value;
                }
                else
                {
                    throw new Exception("Cores disponíveis: Prata, Preto e Branco");
        
                }
            }

        }

        //metodo
        public string Descricao()
        {
            return "O carro é : " + Cor;
        }




    }


}
