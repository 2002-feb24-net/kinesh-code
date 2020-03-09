using System;

namespace PersonList
{
    class Program
  {
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Hello world");
        }
        Person person1 = new Person();
        person1.Name = "Paresh";
        person1.Age = 20;

        Person person2 = new Person
        {
            Name = "jigar",
            Age = 18
        };

        Person person3 = new Person
        {
            Name = "Sanjay"
        };
        person3.Age = 43;

        Person person4 = new Person
        {
            Name = " Rahul"
        };
        person4.Age = 40;
        Person person5 = new Person
        {
            Name = "Snehal"
        };
        person5.Age = 30;

        Console.WriteLine("name"+"age");
        Console.Read();
    }
  }
}

