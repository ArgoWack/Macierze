using System;
using System.Collections.Generic;
using System.Text;

namespace Stary_program_główny
{
    class Single_matrix_operations
    {
        public static void Matrix_implementation(int D, double[,] table1, double[,] table2)
        {
            int l = Exceptions_handling.Exceptions_int(1, 2,
                "Napisz czy chcesz wprowadzic jedna - 1, czy dwie -2 tabele");
            for (int i = 0; i < D; i++)
            {
                for (int j = 0; j < D; j++)
                {
                    table1[i, j] = Exceptions_handling.Exceptions_double_Table2D(i, j, "Wstaw liczbe dla a");
                }
            }

            if (l == 2)
            {
                for (int i = 0; i < D; i++)
                {
                    for (int j = 0; j < D; j++)
                    {
                        table2[i, j] = Exceptions_handling.Exceptions_double_Table2D(i, j, "Wstaw liczbe dla b");
                    }
                }
            }
        }

        // wyznacznik działa dla wymiarów 0-3 tylko, dla >=4  - Brak
        public static void Det(int D, double[,] table1)
        {
            {
                double det = 0;
                switch (D)
                {
                    case 0:
                    {
                        //pusta
                        Console.WriteLine("wyznacznik nie istnieje");
                        break;
                    }
                    case 1:
                    {
                        //singleton
                        Console.WriteLine("wyznacznik Det(A)=" + table1[0, 0]);
                        break;
                    }
                    case 2:
                    {
                        //ad-bc
                        det = table1[0,0] * table1[1, 1] - table1[1, 0] * table1[0, 1];
                        Console.WriteLine("wyznacznik Det(A)=" + det);
                        break;
                    }
                    case 3:
                    {
                        //sarrus
                        det = table1[0, 0] * table1[1, 1] * table1[2, 2] +
                              table1[0, 1] * table1[1, 2] * table1[2, 0] +
                              table1[0, 2] * table1[1, 0] * table1[2, 1]
                              - table1[0, 2] * table1[1, 1] * table1[2, 1] * table1[1, 0] -
                              table1[0, 0] * table1[1, 2] * table1[2, 1] -
                              table1[0, 1] * table1[1, 0] * table1[2, 2];
                        Console.WriteLine("wyznacznik Det(A)=" + det);
                        break;
                    }
                    default:
                    {
                        // Liczenie wyznacznika  dla D>3 np: La'placem dopiero do napisania
                        /*
                        int w = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                            det(table1[i,j])=table3[1,j]*((-1)^(1+j))*(
                             w++;
                                for (int a = w; a < D; a++)
                                {
                                    int n = 0;
                                    for (int b = 0; b < D; b++)
                                    {
                                        det(table1[a,b])=table1[a, if (b < 0 + n)
                                        {
                                           j
                                        }
                                        else
                                        {
                                            j + 1
                                        }]

                                        n++;
                                    }
                                }

                            )
                            }
                        }
                        Console.WriteLine("wyznacznik Det(A)=" + det(table1[i,j]));
                        */
                        break;

                    }
                }
            }
        }

        public static void Transposition(int D, double[,] table1, double[,] table3)
        {
            // Transpozycja macierzy A
            Console.WriteLine("Macierz transpozycja macierzy A:");
            for (int i = 0; i < D; i++)
            {
                for (int j = 0; j < D; j++)

                {
                    table3[i, j] = table1[j, i];
                    Console.WriteLine("t" + i + j + "=" + (table3[i, j]));
                }
            }
        }

        public static void Trace(int D, double[,] table1)
        {
            // liczenie śladu
            int i = 0;
            int j = 0;
            int amount_added_count = 0;
            double value = 0;
            while (amount_added_count < D)
            {
                value += table1[i, j];
                i++;
                j++;
                amount_added_count++;
            }
            Console.WriteLine("ślad wynosi: " + value);
        }

        public static void Multiplication_scalar(int D, double[,] table1, double[,] table3)
        {
            //mnożenie macierzy przez skalar
            double a = Exceptions_handling.Exceptions_double_without_limits("Podaj skalar:");
            for (int i = 0; i < D; i++)
            {
                for (int j = 0; j < D; j++)
                {
                    table3[i, j] = table1[i, j] * a;
                    Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                }
            }
        }

       public static void Elementary_operations(int D, double[,] table1, double[,] table3)
        {
            int choice_number1 = Exceptions_handling.Exceptions_int(0, 1, "Wybierz czy chcesz operować na: \n kolumnach- 0 \n wierszach 1 \n)");
            if (choice_number1 == 0)
            {
                Console.WriteLine("Wybrałeś operacje na kolumnach");
                int choice_number2 = Exceptions_handling.Exceptions_int(0, 3,
                    "Wybierz, czy chcesz: odejmować od siebie kolumny - 0 \n mnożyć kolumny przez skalar - 1 \n usunąć kolumnę - 2 \n zamienić miejscami kolumny - 3 \n");
                switch (choice_number2)
                {
                    case 1:
                        {
                            int column_number = Exceptions_handling.Exceptions_int(0, D, "wybierz kolumnę");
                            double scalar = Exceptions_handling.Exceptions_double_without_limits("Podaj skalar:");

                            for (int i = 0; i < D; i++)
                            {
                                for (int j = 0; j < D; j++)
                                {
                                    table1[i, j] = table1[i, column_number] * scalar;
                                    Console.WriteLine("c" + i + j + "=" + (table1[i, j]));
                                }
                            }
                            break;
                        }
                    case 0:
                        {
                            int column1 = Exceptions_handling.Exceptions_int(0, D, "wybierz kolumnę do której będziesz dawał/odejmował inną kolumnę");
                            double scalar1 = Exceptions_handling.Exceptions_double_without_limits("Podaj skalar przez który mnożysz podaną kolumnę");
                            int choice_number3 = Exceptions_handling.Exceptions_int(0, 1, "Wybiersz operację: dodawanie - 0 \n odejmowanie - 1 \n");
                            int column2 = Exceptions_handling.Exceptions_int(0, D, "wybierz kolumnę którą będziesz dodawał/odejmował");
                            double scalar2 = Exceptions_handling.Exceptions_double_without_limits("Podaj skalar przez który mnożysz podaną kolumnę");

                            for (int i = 0; i < D; i++)
                            {
                                for (int j = 0; j < D; j++)
                                {
                                    if (choice_number3 == 0)
                                    {
                                        table1[i, column1] = table1[i, column1] * scalar1 + table1[i, column2] * scalar2;
                                    }
                                    else if (choice_number3 == 1)
                                    {
                                        table1[i, column1] = table1[i, column1] * scalar1 - table1[i, column2] * scalar2;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Błędne dane");
                                    }
                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            int column = Exceptions_handling.Exceptions_int(0, D, "wybierz kolumnę którą chcesz usunąć");

                            int j = 0;
                            for (int i = 0; i < D; i++)
                            {
                                if (j == column)
                                {
                                    j++;
                                }
                                for (j = 0; j < D - 1; j++)
                                {
                                    if (j < column)
                                    {
                                        table1[i, j] = table1[i, j];
                                    }
                                    else
                                    {
                                        table1[i, j] = table1[i, j + 1];
                                    }
                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            int column1 = Exceptions_handling.Exceptions_int(0, D, "wybierz numer pierwszej kolumny do zamiany");
                            int column2 = Exceptions_handling.Exceptions_int(0, D, "wybierz numer drugiej kolumny do zamiany");
                            for (int i = 0; i < D; i++)
                            {
                                for (int j = 0; j < D; j++)
                                {
                                    if ((column2 == j) && (column1 == j))
                                    {
                                        if (column2 == j)
                                        {
                                            table3[i, j] = table1[i, j];
                                            table1[i, j] = table1[i, column1];
                                        }
                                        else // k==j
                                        {
                                            table1[i, j] = table3[i, column2];
                                        }
                                    }
                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Błędne dane");
                            break;
                        }
                }
            }
            else if (choice_number1 == 1)
            {
                Console.WriteLine("Wybrałęś operacje na wierszach");
                int choice_number2 = Exceptions_handling.Exceptions_int(0, 3,
                    "Wybierz, czy chcesz: odejmować od siebie wiersze - 0 \n mnożyć wiersze przez wiersze - 1 \n usunąć wiersz -2 \n zamienić miejscami wiersze - 3  \n");
                switch (choice_number2)
                {
                    case 1:
                        {
                            int row = Exceptions_handling.Exceptions_int(0, D, "wybierz wiersz");
                            double scalar = Exceptions_handling.Exceptions_double_without_limits("Podaj skalar");

                            for (int i = 0; i < D; i++)
                            {
                                for (int j = 0; j < D; j++)
                                {
                                    table1[i, j] = table1[i, row] * scalar;
                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }
                            break;
                        }
                    case 0:
                        {
                            int row1 = Exceptions_handling.Exceptions_int(0, D, "wybierz wiersz do której będziesz dodawał/odejmował inny wiersz ");
                            double scalar1 = Exceptions_handling.Exceptions_double_without_limits("Podaj skalar przez który mnożysz podany wiersz");
                            int choice_number3 = Exceptions_handling.Exceptions_int(0, 1, "Wybiersz operację: dodawanie - 0 \n odejmowanie - 1 \n");
                            int row2 = Exceptions_handling.Exceptions_int(0, D, "wybierz wiersz który będziesz dodawał/odejmował");
                            double scalar2 = Exceptions_handling.Exceptions_double_without_limits("Podaj skalar przez który mnożysz podany wiersz");
                            for (int i = 0; i < D; i++)
                            {
                                for (int j = 0; j < D; j++)
                                {
                                    if (choice_number3 == 0)
                                    {
                                        table1[row1, j] = table1[row1, j] * scalar1 + table1[row2, j] * scalar2;
                                    }
                                    else if (choice_number3 == 1)
                                    {
                                        table1[row1, j] = table1[row1, j] * scalar1 - table1[row2, j] * scalar2;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Błędne dane");
                                    }

                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            int row = Exceptions_handling.Exceptions_int(0, D, "wybierz wiersz który chcesz usunąć");

                            int i = 0;
                            if (i == row)
                            {
                                i++;
                            }
                            for (i = 0; i < D - 1; i++)
                            {
                                for (int j = 0; j < D; j++)
                                {
                                    if (i < row)
                                    {
                                        table1[i, j] = table1[i, j];
                                    }
                                    else
                                    {
                                        table1[i, j] = table1[i + 1, j];
                                    }
                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            //zamiana miejscami wierszach
                            int row1 = Exceptions_handling.Exceptions_int(0, D, "wybierz numer pierwszego wiersza do zamiany");
                            int row2 = Exceptions_handling.Exceptions_int(0, D, "wybierz numer drugiego wiersza do zamiany");
                            for (int i = 0; i < D; i++)
                            {
                                for (int j = 0; j < D; j++)
                                {
                                    if ((row2 == j) && (row1 == j))
                                    {
                                        if (row2 == j)
                                        {
                                            table3[i, j] = table1[i, j];
                                            table1[i, j] = table1[row1, j];
                                        }
                                        else // k==j
                                        {
                                            table1[i, j] = table3[row2, i];
                                        }
                                    }
                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("błędne dane");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("błędne dane");
            }
        }

       public static void Matrices_powering(int D, double[,] table1, double[,] table3)
       {
            // Potęgowanie macierzy
            int power = Exceptions_handling.Exceptions_uint_without_limits("Podaj potęgę: ");
            if (power == 0)
            {
                Console.WriteLine("Value = 1");
            }
            else
            {
                //ustawienie table3 jako macierzy jednostkowej
                for (int i = 0; i < D; i++)
                {
                    for (int j = 0; j < D; j++)
                    {
                        if (i == j)
                        {
                            table3[i, j] = 1;
                        }
                        else
                        {
                            table3[i, j] = 0;
                        }
                    }
                }
                int count = 0;
                double[,] table0 = new double[D, D];
                while (count < power)
                {
                    for (int i = 0; i < D; i++)
                    {
                        for (int j = 0; j < D; j++)
                        {
                            for (int k = 0; k < D; k++)
                            {
                                table0[i, j] += table1[i, k] * table3[k, j];
                            }
                        }
                    }
                    for (int i = 0; i < D; i++)
                    {
                        for (int j = 0; j < D; j++)
                        {
                            table3[i, j] = table0[i, j];
                            table0[i, j] = 0;
                            if (count + 1 == power)
                            {
                                //Ostatnia pętla - wypisywanie wartości docelowej macierzy table3
                                Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                            }
                        }
                    }
                    count++;
                }
            }
       }
        public static void Matrices_characteristic(int D, double[,] table1, double[,] table3)
        {
            
               if(1==1)//Czy jest kwadratowa?
               {
                    // Jeśli jest kwadratowa
                    Console.WriteLine("macierz jest kwadratowa \n");
                    {
                        int Count = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                                if (i == j)
                                {
                                    if (table1[i, j] == 1)
                                        Count++;
                                }
                                else
                                {
                                    if (table1[i, j] == 0)
                                        Count++;
                                }
                            }
                        }
                        if (Count == D * D)
                        {
                            Console.WriteLine("macierz jest jednostkowa \n");
                        }
                    }
                    // Czy jest symetryczna
                    {
                        int Count = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                                if (table1[i, j] == table1[j, i])
                                    Count++;
                            }
                        }
                        if (Count == D * D)
                        {
                            Console.WriteLine("macierz jest symetryczna \n");
                        }
                    }
                    // Czy jest antysymetryczna
                    {
                        int Count = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                                if (table1[i, j] == -table1[j, i])
                                    Count++;
                            }
                        }
                        if (Count == D * D)
                        {
                            Console.WriteLine("macierz jest antysymetryczna \n");
                        }
                    }
                    // Czy jest diagonalna
                    {
                        int Count = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                                if (i != j)
                                {
                                    if (table1[i, j] == 0)
                                        Count++;
                                }
                            }
                        }
                        if (Count == D * D)
                        {
                            Console.WriteLine("macierz jest diagonalna \n");
                        }
                    }
                    // Czy jest dolna trójkątna
                    {
                        int Count = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                                if (i < j)
                                {
                                    if (table1[i, j] == 0)
                                        Count++;
                                }
                                else
                                {
                                    Count++;
                                }
                            }
                        }
                        if (Count == D * D)
                        {
                            Console.WriteLine("macierz jest dolna trójkątna \n");
                        }
                    }
                    // Czy jest górna trójkątne
                    {
                        int Count = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                                if (i > j)
                                {
                                    if (table1[i, j] == 0)
                                        Count++;
                                }
                                else
                                {
                                    Count++;
                                }
                            }
                        }
                        if (Count == D * D)
                        {
                            Console.WriteLine("macierz jest górna trójkątna \n");
                        }
                    }
                    // Czy jest ortogonalna?  A x AT=I (macierz razy jej transpozycja = jednostkowa)
                    {
                        int Count = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                                if (i == j)
                                {
                                    if (table1[i, j] * table1[j, i] == 1)
                                        Count++;
                                }
                                else
                                {
                                    if (table1[i, j] * table1[j, i] == 0)
                                        Count++;
                                }
                            }
                        }
                        if (Count == D * D)
                        {
                            Console.WriteLine("macierz jest diagonalna \n");
                        }
                    }
                   // Czy jest stochastyczna
                   {
                    bool right_stochastic_matrix()
                    {
                        double sum1 = 0;
                        double sum2 = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                                if (i % 2 == 0)
                                {
                                    if (j == 0)
                                    {
                                        sum1 = 0;
                                    }
                                    sum1 += table1[i, j];
                                    if (i == 0 && j == D - 1)
                                    {
                                        sum2 = sum1;
                                    }
                                    if (sum1 != 1 && j == D - 1)
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
                                    if (sum2 != 1 && j == D - 1)
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
                        double sum1 = 0;
                        double sum2 = 0;
                        for (int j = 0; j < D; j++)
                        {
                            for (int i = 0; i < D; i++)
                            {
                                if (j % 2 == 0)
                                {
                                    if (i == 0)
                                    {
                                        sum1 = 0;
                                    }
                                    sum1 += table1[i, j];
                                    if (j == 0 && i == D - 1)
                                    {
                                        sum2 = sum1;
                                    }
                                    if (sum1 != 1 && i == D - 1)
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
                                    if (sum2 != 1 && i == D - 1)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                        return true;
                    }

                    if (right_stochastic_matrix() == true && left_stochastic_matrix() == true)
                    {
                        Console.WriteLine("Jest to macierz stochastyczna podwójna. \n");
                    }
                    else if (left_stochastic_matrix() == true)
                    {
                        Console.WriteLine("Jest to macierz stochastyczna lewa. \n");
                    }
                    else if (right_stochastic_matrix() == true)
                    {
                        Console.WriteLine("Jest to macierz stochastyczna prawa. \n");
                    }
                }
                //kwadrat magiczny
                {
                    bool comparing_row_sums()
                    {
                        double sum1 = 0;
                        double sum2 = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                                // if row is even
                                if (i % 2 == 0)
                                {
                                    if (j == 0)
                                    {// Nullifying the previous sum1
                                        sum1 = 0;
                                    }
                                    // Adding cells of given row
                                    sum1 += table1[i, j];
                                    if (i == 0 && j == D - 1)
                                    {
                                        sum2 = sum1;
                                    }
                                    // when all row was summed checking if it has the same value as the previous one
                                    if (sum1 != sum2 && j == D - 1)
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
                                    if (sum1 != sum2 && j == D - 1)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                        return true;
                    }
                    bool comparing_column_sums()
                    {
                        double sum1 = 0;
                        double sum2 = 0;
                        for (int j = 0; j < D; j++)
                        {
                            for (int i = 0; i < D; i++)
                            {
                                // if row is even columns
                                if (j % 2 == 0)
                                {
                                    if (i == 0)
                                    {// Nullifying the previous sum1
                                        sum1 = 0;
                                    }
                                    // Adding cells of given row
                                    sum1 += table1[i, j];
                                    if (j == 0 && i == D - 1)
                                    {
                                        sum2 = sum1;
                                    }
                                    // when all row was summed checking if it has the same value as the previous one
                                    if (sum1 != sum2 && i == D - 1)
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
                                    if (sum1 != sum2 && i == D - 1)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                        return true;
                    }
                    bool comparing_diagonal_sums()
                    {
                        double sum1 = 0;
                        double sum2 = 0;
                        for (int i = 0; i < D; i++)
                        {
                            for (int j = 0; j < D; j++)
                            {
                                if (i == j)
                                {
                                    sum1 += table1[i, j];
                                    if (i == D - 1 && j == D - 1)
                                    {
                                        if (sum1 != sum2)
                                        {
                                            return false;
                                        }
                                    }
                                }
                                if (i + j == D - 1)
                                {
                                    sum2 += table1[i, j];
                                }
                            }
                        }
                        return true;
                    }
                    if (comparing_row_sums() == true && comparing_column_sums() == true && comparing_diagonal_sums() == true)
                    {
                        Console.WriteLine("Jest to kwadrat magiczny. \n");
                    }
                    else
                    {
                        Console.WriteLine("NIe jest to kwadrat magiczny. \n");
                    }
                }
                // miejsce na kolejne metody charakterystyki macierzy kwadratowych
            }
               // charakterystyki dotyczące macierzy niekwadratowych
            {
                // Macierz rzadka (większość elementów = 0)
                {
                    int Count = 0;
                    for (int i = 0; i < D; i++)
                    {
                        for (int j = 0; j < D; j++)
                        {
                            if (table1[i, j] == 0)
                            {
                                Count++;
                            }
                        }
                    }
                    if (2 * Count > D * D)
                    {
                        Console.WriteLine("macierz jest rzadka \n");
                    }
                }
                // Czy macierzą zerową
                {
                    int Count = 0;
                    for (int i = 0; i < D; i++)
                    {
                        for (int j = 0; j < D; j++)
                        {
                            if (table1[i, j] == 0)
                            {
                                Count++;
                            }
                        }
                    }
                    if (Count == D * D)
                    {
                        Console.WriteLine("macierz jest zerowa \n");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
