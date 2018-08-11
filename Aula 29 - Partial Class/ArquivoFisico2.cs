using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_29___Partial_Class
{
    public partial class ArquivoFisico
    {
        private string Nome { get; set; }

        public ArquivoFisico(string _nome)
        {
            Nome = _nome;
        }
    }
}

