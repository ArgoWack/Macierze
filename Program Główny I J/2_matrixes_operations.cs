using System;
using System.Collections.Generic;
using System.Text;

namespace Program_Główny_I_J
{
   
        class _2_matrixes_operations
        {
            public static void Matrices_substraction(int Rows1, int Columns1, int Rows2, int Columns2, double[,] table1, double[,] table2)
            {
                if (Rows1 != Rows2 || Columns1 != Columns2)
                {
                    Console.WriteLine("Nie można odejmować macierzy o różnych rozmiarach");
                }
                else
                {
                    double[,] table3 = new double[Rows1, Columns1];
                    //odejmowanie macierzy A-B
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Columns1; j++)
                        {
                            table3[i, j] = table1[i, j] - table2[i, j];
                            Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                        }
                    }
                }
            }


            public static void Matrices_adding(int Rows1, int Columns1, int Rows2, int Columns2, double[,] table1, double[,] table2)
            {
                if (Rows1 != Rows2 || Columns1 != Columns2)
                {
                    Console.WriteLine("Nie można dodawać macierzy o różnych rozmiarach");
                }
                else
                {
                    double[,] table3 = new double[Rows1, Columns1];
                    //dodawanie macierzy A+B
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Columns1; j++)
                        {
                            table3[i, j] = table1[i, j] + table2[i, j];
                            Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                        }
                    }
                }
            }

            public static void Matrices_multiplication(int Rows1, int Columns1, int Rows2, int Columns2, double[,] table1, double[,] table2)
            {
                if (Columns1 == Rows2)
                {
                    double[,] table3 = new double[Rows1, Columns2];
                    // Mnożenie macierzy A x B
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Columns2; j++)
                        {
                            for (int k = 0; k < Rows2; k++)
                            {
                                table3[i, j] += table1[i, k] * table2[k, j];
                            }
                            Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nie można mnożyć macierzy o podanych rozmiarach");
                }
            }
            public static void Hadamard_product(int Rows1, int Columns1, int Rows2, int Columns2, double[,] table1, double[,] table2)
            {
                if (Rows1 == Rows2 && Columns1 == Columns2)
                {
                    double[,] table3 = new double[Rows1, Columns1];
                    //iloczyn hadamarda
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Columns1; j++)
                        {
                            table3[i, j] = table1[i, j] * table2[i, j];
                            Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                        }
                    }
                }
                else
                {
                Console.WriteLine("Nie można mnożyć wyliczać iloczynu Hadamarda dla macierzy o różnych rozmiarach");
                }
            }

            public static void Kronecker_product(int Rows1, int Columns1, int Rows2, int Columns2, double[,] table1, double[,] table2)
            {
            // iloczyn Kroneckera

                double[,] table3 = new double[Rows1 * Rows2, Columns1 * Columns2];

                    for (int i = 0; i < Rows1 * Rows2; i++)
                    {
                        for (int j = 0; j < Columns1 * Columns2; j++)
                        {
                            table3[i, j] = table1[i / Rows1, j / Columns1] * table2[i % Rows2, j % Columns2];
                            Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                        }
                    }
            }
        }
}
