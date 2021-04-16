using System;

namespace Test_project
{
    class Program
    {
        // stochastyczna lewa
        // stochastyczna prawa
        // stochastyczna podwójna
        static void Main(string[] args)
        {
            {
                int Rows1 = 3;

                int[,] table1 = new int[3,3];

                table1[0, 0] = 1;
                table1[1, 0] = 1;
                table1[2, 0] = 1;

                table1[0, 1] = 0;
                table1[1, 1] = 0;
                table1[2, 1] = 0;

                table1[0, 2] = 0;
                table1[1, 2] = 0;
                table1[2, 2] = 0;

                bool right_stochastic_matrix()
                {
                    int sum1 = 0;
                    int sum2 = 0;
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Rows1; j++)
                        {
                            if (i % 2 == 0)
                            {
                                if (j==0)
                                {
                                    sum1 = 0;
                                }
                                sum1 += table1[i, j];
                                if (i == 0 && j == Rows1-1)
                                {
                                    sum2 = sum1;
                                }
                                if (sum1 != 1 && j == Rows1-1)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                if (j == 0)
                                {
                                    sum2 = 0;
                                }
                                sum2 += table1[i, j];
                                if (sum2 != 1 && j == Rows1-1)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    return true;
                }
                bool left_stochastic_matrix()
                {
                    int sum1 = 0;
                    int sum2 = 0;
                    for (int j = 0; j < Rows1; j++)
                    {
                        for (int i = 0; i < Rows1; i++)
                        {
                            if (j % 2 == 0)
                            {
                                if (i == 0)
                                {
                                    sum1 = 0;
                                }
                                sum1 += table1[i, j];
                                if (j == 0 && i == Rows1 - 1)
                                {
                                    sum2 = sum1;
                                }
                                if (sum1 != 1 && i == Rows1 - 1)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    sum2 = 0;
                                }
                                sum2 += table1[i, j];
                                if (sum2 != 1 && i == Rows1 - 1)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    return true;
                }               

                if (right_stochastic_matrix()==true && left_stochastic_matrix() == true)
                {
                   Console.WriteLine("Jest to macierz stochastyczna podwójna. \n");
                }
                else if (left_stochastic_matrix() == true)
                {
                    Console.WriteLine("Jest to macierz stochastyczna lewa. \n");
                }
                else if (right_stochastic_matrix()==true)
                {
                    Console.WriteLine("Jest to macierz stochastyczna prawa. \n");
                }
            }
            Console.ReadKey();
        }
    }
}
