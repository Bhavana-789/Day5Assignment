using System;

namespace Day5_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic C# programs");
            //UC2_LeapYear
            Console.WriteLine("Program to Check LeapYear");
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100! == 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap year", year);
            }

        }
    }
}















