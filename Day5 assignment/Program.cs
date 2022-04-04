using System;

namespace Day5_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic C# programs");
            //UC2_LeapYear
            Console.Write("Calculating power of 2");
            Console.WriteLine("------------------");
            int value = 2;
            int N;
            for (N = 0; N <= 30; N++)
            {
                Console.WriteLine($"{value}^{N} = {(long)Math.Pow(value, N)} (0*{(long)Math.Pow(value, N):X})");
            }
        }
    }
}



    

















