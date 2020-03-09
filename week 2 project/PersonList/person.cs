//1. Push your code to your personal code repo (e.g. mine is 2002-feb24-net/nick-code).
//2. Make a new project named `PersonList` in a folder named `PersonList`. (So the path to theProgram.cs file will be: `<repo>/PersonList/Program.cs`).
//3. Create a Person class to represent a person, having (1) a name, and (2) at least one other pieceof data. Do not use any public fields.
//4. Implement 1 or more constructors, to enforce a requirement that a Person can't exist without aname.
//5. Override ToString method, to return the name of each Person.

using System;
namespace PersonList
{
    class Person
    {
        //Create a person class that has public properties for First and last names and a private property for their age.
        // Getter & Setter
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        // Make a constructor which is used to populate the properties at the time of the objects creation:
        // Public constructor
        public Person(string fname, string lname, int age)
        {
            Fname = fname;
            Lname = lname;
            Age = age;
        }
    }
}
