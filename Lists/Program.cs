using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int howmany = numbers.Count;
            numbers.Add(123);
            int firstItems = numbers[0];
            numbers[0] = 5;
            numbers.Insert(0,1000);
            numbers.Contains(500);//false
            numbers.Add(500);
            numbers.Contains(500); //true
            numbers.RemoveAt(2);//remove third item
            numbers.Remove(500);//remove first 500 that it finds,searching from the left
            
            int sum = 0;
            foreach( int num in numbers )
                {
                    sum += num;

                }
        }
    }
}
