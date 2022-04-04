using System;

namespace Day5_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic C# programs");
            //UC9_Alphabet
            Console.WriteLine("Program to check Vowel or Consonant");
            char ch;
            Console.WriteLine("Enter a character :");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine($"\n\t{ch} is a Vowel");
                    break;
                default:
                    Console.WriteLine($"\n\t{ch} is a Consonant");
                    break;
            }
            Console.ReadKey();
        }
    }
}
    


        
    


    
    


        
    




    

















