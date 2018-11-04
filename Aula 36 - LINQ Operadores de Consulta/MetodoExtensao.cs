using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_36___LINQ_Operadores_de_Consulta
{
    public static class MetodoExtensao
    {
        //estende a classe string 
        //indicado pela palavra this antes do nome do primeiro argumento do método
        public static int ContaCaracteres(this string texto)
        {
            var Contador = texto.Length;
            return Contador;
        }

        //estende a classe string
        public static int ContaPalavras(this string texto)
        {
            return texto.Split(new char[] { ' ', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}
