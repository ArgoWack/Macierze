using System;
using System.Collections.Generic;
namespace Słownik_tablica
{
    class Program
    {
        static Queue<int> Add_Dictionary()
        {
            Queue<int> Matrixes = new Queue<int>();

            Dictionary<string, Queue<int>> Dictionary_name = new Dictionary<string, Queue<int>>();

            Console.WriteLine("\n Enter the number of rows");
            int Rows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter the number of columns");
            int Columns = Int32.Parse(Console.ReadLine());

            Matrixes.Enqueue(Rows);
            Matrixes.Enqueue(Columns);

            for (int k = 2; k < Rows * Columns + 2; k++)
            {
                Console.WriteLine("Enter the value for: h" + (k - 2));

                Matrixes.Enqueue(Int32.Parse(Console.ReadLine()));
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

        static int[,] Addmatrix()
        {
            Dictionary<string, int[,]> tablice = new Dictionary<string, int[,]>();

            Console.WriteLine("\n Enter the number of rows");
            int Rows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter the number of columns");
            int Columns = Int32.Parse(Console.ReadLine());

            int[,] first = new int[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j <Columns; j++)
                {
                    Console.WriteLine("Enter the value for: h" + i + j);

                    first[i,j]=(Int32.Parse(Console.ReadLine()));
                }
            }

            Console.WriteLine("Enter string name \n");
            tablice[Console.ReadLine()] = first;

            // the end of the declaration of Dictionairy
            // the beggining of outputing Dictionairy 

            Console.WriteLine("Enter string name \n");
            string stringName = Console.ReadLine();

            // wypisać tablice dla pewności 

            Console.ReadKey();
            return tablice[stringName];
        }

        static void Main(string[] args)
        {
            Add_Dictionary();
            Console.WriteLine("Podaj nazwę słownika którego wartość chcesz wyświetlić");

            Console.ReadKey();

            Dictionary<string, int[,]> tablice = new Dictionary<string, int[,]>();
            string nazwa = "pierwsza";
            int w = 2;
            int k = 3;
            int[,] first = new int[w, k];
            first[0, 0] = 1;
            first[0, 1] = 1;
            first[0, 2] = 1;
            first[1, 0] = 21;
            first[1, 1] = 41;
            first[1, 2] = 1;
            tablice.Add(nazwa, first);
            tablice.Add("inna", first);

            Console.WriteLine(tablice["pierwsza"][1, 1]);

            int[,] biezaca = tablice["pierwsza"];
            Console.WriteLine(biezaca[1, 0]);

            Console.ReadKey();
        }
    }
}
