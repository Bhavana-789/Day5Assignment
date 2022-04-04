using System;

namespace Day5_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic C# programs");
            //UC1
            Console.WriteLine("Welcome to Flip Coin Program");

            int count = 0;
            int Heads = 0;
            int Tails = 0;
            while (count < 100)
            {
                Random random = new Random();
                int result = random.Next(0, 2);
                if (result == 0)
                {
                    Console.WriteLine("Heads!");
                    Heads = Heads + 1;
                    count = count + 1;

                }
                else
                {
                    Console.WriteLine("Tails!");
                    Tails = Tails + 1;
                    count = count + 1;
                }
            }
            Console.WriteLine("Heads=" + Heads + "Tails=" + Tails + "count=" + count);
            int totaltails = count - Heads;
            int totalheads = count - Tails;
            Console.WriteLine("total heads is" + totalheads + "total tails is" + totaltails);
            float headPercent = ((float)totalheads / count) * 100;
            float tailPercent = ((float)totaltails / count) * 100;
            Console.WriteLine("The percentage of heads is:" + Math.Round(headPercent, 2)
                             + "The percentage of tails is:" + Math.Round(tailPercent, 2));
        }



    }
}

            



           


        
    

