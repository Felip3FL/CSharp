using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17___Diferenca_entre_Classes_e_Structs
{
    public struct Livro : IModelo
    {
        public string Autor;
        public string Titulo;
        public decimal Preco;

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
