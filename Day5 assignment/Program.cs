using System;

namespace Day5_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic C# programs");
            //UC10_LargestNum
            Console.WriteLine("Program to check largest number");
            int n1, n2, n3;
            Console.Write("Enter First Number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("The 1st number is largest");
                }
                else
                {
                    Console.WriteLine("The 3rd Number is largest");
                }
            }
            else if (n2 > n3)
            {
                Console.WriteLine("The 2nd number is largest");
            }
            else
                Console.WriteLine("The 3rd number is largest");
        }
    }
}

    


        
    


    
    


        
    




    

















