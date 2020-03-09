using System;

namespace PersonList
{
    class Program
    {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.Clear();

                    //Task name
                    Console.WriteLine("Class - Person Name and Age\n\n");

//6. In the Program class, create a List of at least five Persons, and use Console to show the user the List's contents.

                    // Create a Person object and display their full name and age to the user:
                    Person p1 = new Person("kinesh", "mistry", 25);
                    Person p2 = new Person("snehal", "Patel", 23);
                    Person p3 = new Person("Mitesh", "Parikh", 20);
                    Person p4 = new Person("Rahul", "Patel", 21);
                    Person p5 = new Person("max", "Ramos", 23);

                    Console.WriteLine("Name: " + p1.Fname + " " + p1.Lname + " " ); 
                    Console.WriteLine("Age: " + p1.Age);
                    Console.WriteLine("Name: " + p2.Fname + " " + p2.Lname + " " );
                    Console.WriteLine("Age: " + p2.Age);
                    Console.WriteLine("Name: " + p3.Fname + " " + p3.Lname + " " );
                    Console.WriteLine("Age: " + p3.Age);
                    Console.WriteLine("Name: " + p4.Fname + " " + p4.Lname + " " );
                    Console.WriteLine("Age: " + p4.Age);
                    Console.WriteLine("Name: " + p5.Fname + " " + p5.Lname + " " );
                    Console.WriteLine("Age: " + p5.Age);
                    Console.ReadLine();
                }
            }

            static void InsertionSort(List<Person> myPeople)
        {
            for (int i = 1; i < myPeople.Count; i++)
            {
                Person personAtIndex = myPeople[i];
                for (int j = 0; j < i; j++)
                {
                    // Person.ToString() return the name of that person.
                    // Essentially testing if( personAtIndex < mypeople[j] )
                    if(personAtIndex.ToString().CompareTo(myPeople[j].ToString()) < 0)
                    {
                        // When we have found the new index for personAtIndex,
                        // remove that person from its original index,
                        // then insert them at their new index.
                        myPeople.Remove(personAtIndex);
                        myPeople.Insert(j, personAtIndex);
                        break;
                    }
                }
            }
        }
    }           
}
//10.In a comment, describe the difference between insertion sort and bubble sort.
   //The main difference between bubble sort and insertion sort is
  // that bubble sort performs sorting by checking the neighboring data elements and swapping 
  //them if they are in wrong order while insertion sort performs sorting by transferring one element 
  //to a partially sorted array at a time.
