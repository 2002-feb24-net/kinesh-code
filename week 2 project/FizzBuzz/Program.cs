using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
             int n = 1000; 
  
            // loop for 100 times 
            for (int i = 1; i <= n; i++)                              
            { 
            // number divisible by 5,  
            // print 'Buzz' in place 
            // of the number 
            if (i % 15 == 0)  
                Console.Write("FizzBuzz" + " ");  
  
            // number divisible by 3,  
            // print 'Fizz' in place  
            // of the number 
            else if (i % 3 == 0)      
                Console.Write("Fizz" + " ");  
  
            // number divisible by  
            // 15(divisible by both  
            // 3 & 5), print 'FizzBuzz' 
            // in place of the number 
            else if (i % 5 == 0)                                              
                Console.Write("Buzz" + " ");  
              
            // print the numbers  
            else
                   Console.Write(i + " ");   
                 //Console.Write( i  +"Fizz "); 
                 //Console.Write( i +" Buzz"); 
                 //Console.Write( i +" FizzBuzz ");                  
        } 
        }
    }
}