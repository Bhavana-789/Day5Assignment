using System;

namespace Day5_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic C# programs");
            //UC6_Division
            Console.WriteLine("Computing Quotient and remainder");
            int Divisor, Dividend;
            Console.Write("Enter the value of Divisor: ");
            Divisor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of Dividend: ");
            Dividend = Convert.ToInt32(Console.ReadLine());

            int quotient = Dividend / Divisor;
            int remainder = Dividend % Divisor;
            Console.WriteLine("Quotient=" + quotient);
            Console.WriteLine("Remainder=" + remainder);
            Console.ReadLine();
        }
    }
}

        
    


    
    


        
    




    

















