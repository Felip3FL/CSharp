using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_36___LINQ_Operadores_de_Consulta
{
    public static class IListExtensao
    {
        //Neste exemplo tomamos uma instância da classe que implementa a interface de
        //uma lista de inteiros IList<int> e aumentamos os seus valores com uma quantidade
        //O método de extensão AumentarValorLista pode acessar somente os elementos incluidos na interface IList
        public static void AumentarValorLista(this IList<int> lista, int quantidade)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i] += quantidade;
            }
        }
    }
}
