using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingIEnumerableGeneric
{
    class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class People : IEnumerable<Person>
    {
        public People(Person[] people)
        {
            this.people = people;
        }

        Person[] people;

        public IEnumerator<Person> GetEnumerator()
        {
            for (int index = 0; index < people.Length; index++)
            {
                yield return people[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
