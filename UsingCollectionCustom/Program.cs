using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCollectionCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 42
            };

            Person p2 = new Person
            {
                FirstName = "Jane",
                LastName = "Doe",
                Age = 21
            };

            PeopleCollection people = new PeopleCollection { p1, p2 };
            people.RemoveByAge(42);
            Console.WriteLine(people.Count); // Displays: 1
        }

        public class PeopleCollection : List<Person>
        {
            public void RemoveByAge(int age)
            {
                for (int index = this.Count - 1; index >= 0; index--)
                {
                    if (this[index].Age == age)
                    {
                        this.RemoveAt(index);
                    }
                }
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach (Person p in this)
                {
                    sb.AppendFormat("{0} {1} is {2}", p.FirstName, p.LastName, p.Age);
                }
                return sb.ToString();
            }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}
