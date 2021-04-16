using System;
using System.Collections.Generic;
using System.Text;

namespace Stary_program_główny
{
    class _2_matrixes_operations
    {
        public static void Matrices_substraction(int D, double[,] table1, double[,] table2, double[,] table3)
        {
            //dodawanie macierzy A+B
            for (int i = 0; i < D; i++)
            {
                for (int j = 0; j < D; j++)
                {
                    table3[i, j] = table1[i, j] - table2[i, j];
                    Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                }
            }
        }

        public static void Matrices_adding(int D, double[,] table1, double[,] table2, double[,] table3)
        {
            //dodawanie macierzy A+B
            for (int i = 0; i < D; i++)
            {
                for (int j = 0; j < D; j++)
                {
                    table3[i, j] = table1[i, j] + table2[i, j];
                    Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                }
            }
        }

        public static void Matrices_multiplication(int D, double[,] table1, double[,] table2, double[,] table3)
        {
            // Mnożenie macierzy A x B
            for (int i = 0; i < D; i++)
            {
                for (int j = 0; j < D; j++)
                {
                    for (int k = 0; k < D; k++)
                    {
                        table3[i, j] += table1[i, k] * table2[k, j];
                    }
                    Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                }
            }
        }

        public static void Hadamard_product(int D, double[,] table1, double[,] table2, double[,] table3)
        {
            //iloczyn hadamarda
            for (int i = 0; i < D; i++)
            {
                for (int j = 0; j < D; j++)
                {
                    table3[i, j] = table1[i, j]*table2[i, j];
                    Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                }
            }
        }
        public static void Kronecker_product(int D, double[,] table1, double[,] table2)
        {
            // iloczyn Kroneckera

            double[,] table4 = new double[D * D, D * D];

            for (int i = 0; i < D * D; i++)
            {
                for (int j = 0; j < D * D; j++)
                {
                    table4[i, j] = table1[ i/D, j/D] * table2[i%D,j%D];
                    Console.WriteLine("c" + i + j + "=" + (table4[i,j]));
                }
            }
        }
    }
}
