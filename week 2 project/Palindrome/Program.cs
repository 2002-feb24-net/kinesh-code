using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            foreach (char c in name)
            {
                reverse = c + reverse;
            }
            Console.WriteLine($"The Reverse string is : {reverse}");
            Console.ReadKey();  
        }
    }
}


