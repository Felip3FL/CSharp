using System;

namespace Aula_03___Nullable_Types
{
    class Exemplo
    {
        private void ExemploDaVariaveis()
        {

            //Essa linha somes com as msg de warning do C#
            #pragma warning disable 0, CS0219

            string nome = null;

            //Essa linha dá erro, porque int não pode receber valor em branco ou nulo
            //int valor1 = null;

            int? valor1 = null;
            Nullable<int> valor2 = null;

            double? d = 3.14;
            bool? flag = null;
            char? letra = 'A';
            int?[] array = new int?[10];

        }
    }
}
