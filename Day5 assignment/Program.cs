using System;

namespace Day5_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic C# programs");
            //UC4_NthHarmonic
            Console.WriteLine("Nth Harmonic Program");
            int num;
            Console.Write("Enter the value of N: ");
            num = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (double i = 1; i <= num; i++)
            {
                result += 1 / i;
            }
            Console.WriteLine(Math.Round(result, 2));
            if (num == 0)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine("The Nth Harmonic Number is: " + result);
            }
        }
    }
}

        
    




    

















