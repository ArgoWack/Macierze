using System;

namespace Program_Główny_I_J
{
    // using System.Collections.Generic;
    // wyznacznik działa dla wymiarów 0-3 tylko, dla >=4  - Brak
    // Gaus - Brak
    // liczenie macierzy odwrotnej - Brak
    // operacje elementarne -> zamiana wierszy/kolumn do poprawy

    class Program
    {
        static void Main(string[] args)
        {
            int number_of_matrices = Exceptions_handling.Exceptions_int(1, 2,
                "Napisz czy chcesz wprowadzic jedna - 1, czy dwie -2 tabele");
            int Rows1 = Exceptions_handling.Exceptions_uint_without_limits("Podaj ilość rzędów dla macierzy1");
            int Columns1 = Exceptions_handling.Exceptions_uint_without_limits("Podaj ilość kolumn dla macierzy1");
            double[,] table1 = new double[Rows1, Columns1];
            for (int i = 0; i < Rows1; i++)
            {
                for (int j = 0; j < Columns1; j++)
                {
                    table1[i, j] = Exceptions_handling.Exceptions_double_Table2D(i, j, "Wstaw liczbe dla a");
                }
            }

            if (number_of_matrices == 2)
            {
                int Rows2 = Exceptions_handling.Exceptions_uint_without_limits("Podaj ilość rzędów dla macierzy2");
                int Columns2 = Exceptions_handling.Exceptions_uint_without_limits("Podaj ilość kolumn dla macierzy2");
                double[,] table2 = new double[Rows2, Columns2];
                for (int i = 0; i < Rows2; i++)
                {
                    for (int j = 0; j < Columns2; j++)
                    {
                        table2[i, j] = Exceptions_handling.Exceptions_double_Table2D(i, j, "Wstaw liczbe dla b");
                    }
                }

                int Inner_Choice = Exceptions_handling.Exceptions_int(0, 4,
                    "Wybierz jedną spośród dostepnych opcji na macierzach: \n odejmowanie - 0 \n dodawanie - 1 \n Mnożenie macierzy - 2\n Iloczyn Hadamarda - 3 \n Iloczyn Kroneckera - 4 \n");
                switch (Inner_Choice)
                {
                    case 0:
                    {
                        //działa
                        _2_matrixes_operations.Matrices_substraction(Rows1, Columns1, Rows2, Columns2, table1, table2);
                        break;
                    }
                    case 1:
                    {
                        //działa
                        _2_matrixes_operations.Matrices_adding(Rows1, Columns1, Rows2, Columns2, table1, table2);
                        break;
                    }
                    case 2:
                    {
                        // Działa
                        _2_matrixes_operations.Matrices_multiplication(Rows1, Columns1, Rows2, Columns2, table1,
                            table2);
                        break;
                    }
                    case 3:
                    {
                        _2_matrixes_operations.Hadamard_product(Rows1, Columns1, Rows2, Columns2, table1, table2);
                        // Działa

                        break;
                    }
                    case 4:
                    {
                        _2_matrixes_operations.Kronecker_product(Rows1, Columns1, Rows2, Columns2, table1, table2);
                        // Działa
                        break;
                    }
                    default:
                    {
                        // działa
                        Console.WriteLine("Błędne dane");
                        break;
                    }
                }
            }
            else
            {
                int Outer_Choice = Exceptions_handling.Exceptions_int(0, 7,
                    "Wybierz jedną spośród dostepnych opcji na macierzach: \n Liczenie wyznacznika - 0 \n Transpozycja - 1 " +
                    "\n Liczenie śladu - 2 \n Mnożenie macierzy przez skalar - 3 \n operacje elementarne -4 " +
                    "\n liczenie macierzy odwrotnej -5 \n charakterystyka macierzy - 6 \n potęgowanie macierzy - 7 \n");
                switch (Outer_Choice)
                {

                    case 0:
                        {
                            // działa dla 0,1,2,3
                            Single_matrix_operations.Det(Rows1, Columns1, table1);
                            break;
                        }
                    case 1:
                        {
                            // działa
                            Single_matrix_operations.Transposition(Rows1, Columns1, table1);
                            break;
                        }
                    case 2:
                        {
                            // działa
                            Single_matrix_operations.Trace(Rows1, Columns1, table1);
                            break;
                        }
                    case 3:
                        {
                            // działa
                            Single_matrix_operations.Multiplication_scalar(Rows1, Columns1, table1);
                            break;
                        }
                    case 4:
                        {
                            // do sprawdzenia
                            Single_matrix_operations.Elementary_operations(Rows1, Columns1, table1);
                            break;
                        }
                    case 5:
                        {
                            // Nie działa
                            // liczenie macierzy odwrotnej - Brak
                            Console.WriteLine("Liczenie macierzy odwrotnej: \n");
                            break;
                        }
                    case 6:
                        {
                            // Działa
                            Single_matrix_operations.Matrices_characteristic(Rows1, Columns1, table1);
                            break;
                        }
                    case 7:
                        {
                            // Działa
                            Single_matrix_operations.Matrices_powering(Rows1, Columns1, table1);
                            break;
                        }
                    default:
                        {
                            // działa
                            Console.WriteLine("Błędne dane");
                            break;
                        }
                }
            }
                Console.ReadKey();
        }
    }
}