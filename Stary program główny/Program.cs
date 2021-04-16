using System;

namespace Stary_program_główny
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
                int Dimension = Exceptions_handling.Exceptions_uint_without_limits("Podaj wymiar macierzy kwadratowej");

                double[,] table1 = new double[Dimension, Dimension];
                double[,] table2 = new double[Dimension, Dimension];
                double[,] table3 = new double[Dimension, Dimension];
                Single_matrix_operations.Matrix_implementation(Dimension, table1, table2);
                int Choice = Exceptions_handling.Exceptions_int(0, 12,
                    "Wybierz jedną spośród dostepnych opcji na macierzach: \n odejmowanie - 0 \n dodawanie - 1 \n Liczenie wyznacznika - 2 \n Transpozycja - 3 " +
                    "\n Mnożenie macierzy - 4\n Liczenie śladu - 5 \n Mnożenie macierzy przez skalar - 6 \n operacje elementarne -7 " +
                    "\n liczenie macierzy odwrotnej -8 \n charakterystyka macierzy - 9 \n potęgowanie macierzy - 10 \n Iloczyn Hadamarda - 11 \n Iloczyn Kroneckera - 12 \n");
                switch (Choice)
                {
                    case 0:
                        {
                        //działa
                            _2_matrixes_operations.Matrices_substraction(Dimension, table1, table2, table3);
                            break;
                        }
                    case 1:
                        {
                        //działa
                            _2_matrixes_operations.Matrices_adding(Dimension, table1, table2, table3);
                            break;
                        }
                    case 2:
                        {
                        // działa dla 0,1,2,3
                            Single_matrix_operations.Det(Dimension, table1);
                            break;
                        }
                    case 3:
                        {
                        // działa
                            Single_matrix_operations.Transposition(Dimension, table1, table3);
                            break;
                        }
                    case 4:
                        {
                        // Działa
                            _2_matrixes_operations.Matrices_multiplication(Dimension, table1, table2, table3);
                            break;
                        }
                    case 5:
                        {
                        // działa
                            Single_matrix_operations.Trace(Dimension, table1);
                            break;
                        }
                    case 6:
                        {
                        // działa
                            Single_matrix_operations.Multiplication_scalar(Dimension, table1, table3);
                            break;
                        }
                    case 7:
                        {
                        // do sprawdzenia
                            Single_matrix_operations.Elementary_operations(Dimension, table1, table3);
                            break;
                        }
                    case 8:
                        {
                            // Nie działa
                            // liczenie macierzy odwrotnej - Brak
                            Console.WriteLine("Liczenie macierzy odwrotnej: \n");
                            break;
                        }
                    case 9:
                    {
                        // Działa
                        // Charakterystyka macierzy

                        Single_matrix_operations.Matrices_characteristic(Dimension, table1, table3);

                        // Charakterystyka macierzy
                        // Zagadnienia:
                        // Czy jest kwadratowa
                        // Czy jest symetryczna
                        // Czy jest antysymetryczna
                        // Czy jest diagonalna
                        // Czy jest dolna trójkątna
                        // Czy jest górna trójkątne
                        // Czy jest ortogonalna
                        // Czy jest stochastyczna (lewa/prawa/podwójna)
                        // Czy jest kwadratem magicznym
                        // Czy jest rzadka
                        // Czy macierzą zerową

                        break;
                        }
                    case 10:
                        {
                            // Działa
                            // potęgowanie
                            Single_matrix_operations.Matrices_powering(Dimension,table1,table3);
                            break;
                        }
                    case 11:
                        {
                        //Iloczyn Hadamarda
                        _2_matrixes_operations.Hadamard_product(Dimension, table1, table2, table3);
                        // Działa

                        break;
                        }
                    case 12:
                        {
                        //Kronecker product
                        _2_matrixes_operations.Kronecker_product(Dimension, table1, table2);
                        // Nie działa
                        break;
                        }
                    default:
                        {
                            // działa
                            // wpisanie czegoś spoza zakresu
                            Console.WriteLine("Błędne dane");
                            break;
                        }
                }
                Console.ReadKey();
            }
        }
}




//class Matrix
//{
//    public int rzędy;
//    public int kolumny;

//    List <object> Macierze = new List<object>();



//    public ArraySegment <double,double> myArrSegAll = new ArraySegment<rzędy,kolumny>(,);

//    public ArrayList Matrix = new ArrayList();

//    Matrix.Add(Array[rzędy,kolumny]);
//}


/* static void Charakterystyka(int D, int[,] table1)
 {
     static bool Diagonalna(int D,int[,] table1);
     {
         int s = 0;
         int k = 0;
         while ((k=0) && (s<D))
             for (int i = 0; s < D; i++)
             {
                 for (int j = 0; s < D; j++)
                 {
                     if (i != j)
                     {
                         k += table1[i, j];
                     }
                 }
             }
         return (k == 0);
     }
 }*/

// Czy diagonalna
//Czy trójkątna
//Czy jednostkowa
//static bool CzyPodzielnaPrzez3(int n)
//{
//    //if (n % 3 == 0) return true;
//    //else return false;
//    return (n % 3) == 0; // tak krócej
//}

    //liczenie rzedu macierzy
    //liczenie minora