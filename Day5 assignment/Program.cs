using System;

namespace Day5_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic C# programs");
            //UC7_Swapping
            Console.WriteLine("Pragram to swap a number");
            int num1, num2;
            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping:");
            Console.Write("First Number :{0} \nSecond Number :{1}", num1, num2);

            Console.ReadKey();
        }
    }
}

        
    


    
    


        
    




    

















