using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12___Arrays
{
    class ExemploArray
    {
        static void Main(string[] args)
        {
            var array = new ExemploArray();

            array.ExemploDeclaracao();
            array.ExemploPercorrerArray();


            Console.ReadKey();

        }

        private void ExemploMatriz()
        {
            //array de 3 linhas e 2 colunas
            int[,] numeros1 = new int[3, 2] {
                { 19, 2 },
                { 32, 4 },
                { 51, 6 }
            };

            int[,] numeros2 = new int[3, 2];

            //array de 4 linhas e 3 colunas
            int[,] numeros3 = new int[,] { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 }, 
                { 10, 11, 12 }
            };
            int[,] numeros4 = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };




        }

        private void ExemploPercorrerArray()
        {
            int[,] numeros = new int[3, 2] {
                { 11, 2 },
                { 32, 4 },
                { 57, 6 }
            };

            ////////////////////////////////////////////////////////

            Console.Write("\nFOR:\n");

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine(" {0} ", numeros[i, j]);
                }
            }

            ////////////////////////////////////////////////////////

            Console.Write("\nForeach:\n");

            foreach (int k in numeros)
            {
                Console.Write("{0} ", k);
            }

            ////////////////////////////////////////////////////////

            Console.Write("\nWhile:\n");

            Console.WriteLine("Numero de Colunas: " + numeros.GetLength(1).ToString());
            Console.WriteLine("Numero de Linhas  : " + numeros.GetLength(0).ToString());
            int m = 0;
            int n = 0;
            while (m < 3)
            {
                while (n < 2)
                {
                    Console.WriteLine((numeros[m, n]).ToString());
                    n++;
                }
                n = 0;
                m++;
            }

        }


        private void ExemploTridimensional3Linhas()
        {
            //percorrendo um array tridimensional 3 linhas
            int[,,] arr3D = new int[3, 5, 4];
            arr3D[0, 0, 0] = 1;
            arr3D[0, 1, 0] = 2;
            arr3D[0, 2, 0] = 3;
            arr3D[0, 3, 0] = 4;
            arr3D[0, 4, 0] = 5;
            arr3D[1, 1, 1] = 2;
            arr3D[2, 2, 2] = 3;
            arr3D[2, 2, 3] = 4;
        }

        private void ExemploDeclaracao()
        {
            int[] n2 = { 10, 20, 30, 40, 50 };
            int[] n3 = new int[] { 10, 20, 30, 40, 50 };
            int[] n4 = new int[5] { 10, 20, 30, 40, 50 };
            int[] n5 = new int[5];
            n5[0] = 10;
            n5[1] = 20;
            n5[2] = 30;
            n5[3] = 40;
            n5[4] = 50;

            double[] d1 = new double[5];
            float[] f1 = new float[5];
        }
    }
}
