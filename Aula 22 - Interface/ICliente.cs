using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_22___Interface
{
    public interface ICliente
    {

        //Assinatura do método
        void Teste();

        string Versao { get; set; }
        event EventHandler ValorChanged;  //Não sei o que isso ainda ?????

    }
}
