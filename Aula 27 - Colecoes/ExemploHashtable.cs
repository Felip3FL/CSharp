using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27___Colecoes
{
    class ExemploHashtable
    {

        public static void ExemploDeHashtable()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "Felip3FL");
            hashTable.Add(2, "felipe.com.br");
            hashTable.Add(3, "SSJ");
            hashTable.Add(4, "ASP .NET");

            Console.WriteLine("As chaves da hastable :--");
            foreach (int k in hashTable.Keys)
            {
                Console.WriteLine("Chave {0} {1}", k, hashTable[k]);
            }

            Console.WriteLine("Informe a chave para procurar : ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(hashTable[p].ToString());
            Console.ReadKey();
        }
    }
}
