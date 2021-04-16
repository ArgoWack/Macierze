using System;
using System.Collections.Generic;
using System.Text;

namespace Program_Główny_I_J
{
    class Exceptions_handling
    {
        public static int Exceptions_int(int upper_bound, int lower_bound, string text)
        {
            int Catch_count = 0;
            int loop_count = 0;
            int value = 0;
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine(text);
                        value = int.Parse(Console.ReadLine());
                        if (lower_bound < value || value < upper_bound)
                        {
                            Console.WriteLine("Błędne dane, spróbuj ponowanie: ");
                        }
                    } while (lower_bound < value || value < upper_bound);
                    //FormatException
                }
                catch (Exception)
                {
                    Console.WriteLine("Błędne dane, spróbuj ponowanie: ");
                    loop_count++;
                }
                Catch_count++;
            } while (loop_count == Catch_count);
            return value;
        }
        public static int Exceptions_int_without_limits(string text)
        {
            int Catch_count = 0;
            int loop_count = 0;
            int value = 0;
            do
            {
                try
                {
                    Console.WriteLine(text);
                    value = int.Parse(Console.ReadLine());
                    //FormatException
                }
                catch (Exception)
                {
                    Console.WriteLine("Błędne dane, spróbuj ponowanie: ");
                    loop_count++;
                }
                Catch_count++;
            } while (loop_count == Catch_count);
            return value;
        }
        public static int Exceptions_int_Table2D(int i, int j, string text)
        {
            int Catch_count = 0;
            int loop_count = 0;
            int value = 0;
            do
            {
                try
                {
                    Console.WriteLine(text + i + j);
                    value = int.Parse(Console.ReadLine());
                    //FormatException
                }
                catch (Exception)
                {
                    Console.WriteLine("Błędne dane, spróbuj ponowanie: ");
                    loop_count++;
                }
                Catch_count++;
            } while (loop_count == Catch_count);
            return value;
        }
        public static int Exceptions_uint_without_limits(string text)
        {
            int Catch_count = 0;
            int loop_count = 0;
            uint u_value = 0;
            do
            {
                try
                {
                    Console.WriteLine(text);
                    u_value = uint.Parse(Console.ReadLine());
                    //FormatException
                }
                catch (Exception)
                {
                    Console.WriteLine("Błędne dane, spróbuj ponowanie: ");
                    loop_count++;
                }
                Catch_count++;
            } while (loop_count == Catch_count);

            int value = Convert.ToInt32(u_value);
            return value;
        }
        public static int Exceptions_uint_empty()
        {
            int Catch_count = 0;
            int loop_count = 0;
            uint u_value = 0;
            do
            {
                try
                {
                    u_value = uint.Parse(Console.ReadLine());
                    //FormatException
                }
                catch (Exception)
                {
                    Console.WriteLine("Błędne dane, spróbuj ponowanie: ");
                    loop_count++;
                }
                Catch_count++;
            } while (loop_count == Catch_count);

            int value = Convert.ToInt32(u_value);
            return value;
        }
        public static double Exceptions_double_Table2D(int i, int j, string text)
        {
            int Catch_count = 0;
            int loop_count = 0;
            double value = 0;
            do
            {
                try
                {
                    Console.WriteLine(text + i + j);
                    value = double.Parse(Console.ReadLine());
                    //FormatException
                }
                catch (Exception)
                {
                    Console.WriteLine("Błędne dane, spróbuj ponowanie: ");
                    loop_count++;
                }
                Catch_count++;
            } while (loop_count == Catch_count);
            return value;
        }
        public static double Exceptions_double_without_limits(string text)
        {
            int Catch_count = 0;
            int loop_count = 0;
            double value = 0;
            do
            {
                try
                {
                    Console.WriteLine(text);
                    value = double.Parse(Console.ReadLine());
                    //FormatException
                }
                catch (Exception)
                {
                    Console.WriteLine("Błędne dane, spróbuj ponowanie: ");
                    loop_count++;
                }
                Catch_count++;
            } while (loop_count == Catch_count);
            return value;
        }
    }
}
