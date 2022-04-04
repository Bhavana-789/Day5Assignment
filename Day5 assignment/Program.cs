using System;

namespace Day5_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic C# programs");
            //UC5_Factors
            Console.WriteLine("Program to find Factors of a number");
            int a, b;
            Console.Write("Enter the Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + "is a factor of" + a);

                }
            }
            Console.ReadLine();
        }
    }
}

    
    


        
    




    

















