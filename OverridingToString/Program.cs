using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Doe");
            Console.WriteLine(p); // Displays ‘John Doe’
        }
    }

    class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName +" "+ LastName;
        }
    }

}
