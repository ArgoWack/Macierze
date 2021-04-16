using System;
using System.Collections.Generic;

namespace Słownik_w_mainie
{
        class Program
        {
            class Matrix
            {
                private string Name;
                private List<int> List;
                private int Rows;
                private int Columns;

               // List<int> Matrixes = new List<int>();


                public Matrix()
                {
                    Console.WriteLine("\n Podaj nazwe");
                    string Name = Console.ReadLine();
                    Console.WriteLine("\n Enter the number of rows");
                    int Rows = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\n Enter the number of columns");
                    int Columns = Int32.Parse(Console.ReadLine());

                    List<int> List = new List<int>(Rows * Columns);
                    for (int k = 0; k < Rows * Columns; k++)
                    {
                        Console.WriteLine("Enter the value for: h" + (k));

                        List.Add(Int32.Parse(Console.ReadLine()));
                    }
                }






        }
            static List<int> Add_Dictionary()
            {
                List<int> Matrixes = new List<int>();

                Dictionary<string, List<int>> Dictionary_name = new Dictionary<string, List<int>>();

                Console.WriteLine("\n Enter the number of rows");
                int Rows = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n Enter the number of columns");
                int Columns = Int32.Parse(Console.ReadLine());

                Matrixes.Add(Rows);
                Matrixes.Add(Columns);

                for (int k = 2; k < Rows * Columns + 2; k++)
                {
                    Console.WriteLine("Enter the value for: h" + (k - 2));

                    Matrixes.Add(Int32.Parse(Console.ReadLine()));
                }

                Console.WriteLine("\n");
                int count = 0;
                foreach (var item in Matrixes)
                {
                    if (count == 2)
                    {
                        Console.WriteLine("\n");
                    }
                    count++;
                    Console.WriteLine(item);
                }

                Console.WriteLine("Enter string name \n");
                Dictionary_name[Console.ReadLine()] = Matrixes;

                // the end of the declaration of Dictionairy
                // the beggining of outputing Dictionairy 

                Console.WriteLine("Enter string name \n");
                string stringName = Console.ReadLine();

                int loop_count = 0;
                int i = 0;
                int j = 0;

                foreach (var value in Dictionary_name[stringName])
                {
                    if (loop_count == 0)
                    {
                        Rows = value;
                    }
                    else
                    {
                        Columns = value;
                        int[,] MyArray = new int[Rows, Columns];
                        int inner_count = 0;
                        foreach (var item in Dictionary_name[stringName])
                        {
                            if (inner_count > 1)
                            {
                                MyArray[i, j] = item;
                                j++;
                                if (Columns == j)
                                {
                                    j = 0;
                                    i++;
                                }
                            }
                            inner_count++;
                        }
                        Console.WriteLine("Printing out values of array named: " + stringName + "\n");
                        inner_count = 0;
                        foreach (int item in MyArray)
                        {
                            if (inner_count == Rows)
                            {
                                Console.WriteLine("\n");
                                inner_count = 0;
                            }
                            Console.Write("{0} ", item);
                            inner_count++;
                        }
                        break;
                    }
                    loop_count++;
                }
                Console.ReadKey();
                return Dictionary_name[stringName];
            }
            static void Main(string[] args)
            {

                Matrix savingsAccount = new Matrix();

                Console.WriteLine("Podaj ilość macierzy którą chcesz zadeklarować");
                int Amount = Int32.Parse(Console.ReadLine());
                for (int A = 0; A < Amount; A++)
                {
                    Matrix matrix = new Matrix();


                // Console.WriteLine("Podaj nazwę nowej macierzy");
                //// string Name = (Console.ReadLine());
                //// Name = Console.ReadLine();
                // Matrix Newmatrix = new Matrix();

                /*Add_Dictionary();
                Console.WriteLine("Podaj nazwę słownika którego wartość chcesz wyświetlić");
                */
            }

                Console.ReadKey();
            }
        }    
}
