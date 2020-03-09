using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            this.age = value;
        
        }
    }
            public String toString() 
            {
                return "name: " + Name + " Age: " + age;
            }

            public String getLast() 
            {
               return Name;
            }

   //The main difference between bubble sort and insertion sort is
  // that bubble sort performs sorting by checking the neighboring data elements and swapping 
  //them if they are in wrong order while insertion sort performs sorting by transferring one element 
  //to a partially sorted array at a time.
}