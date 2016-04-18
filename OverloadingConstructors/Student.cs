using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingConstructors
{

    class Student
    {
        public string firstName;
        public string lastName;
        public int grade;
        public string schoolName;
        public Student()
        {
        }
        public Student(string first, string last)
        {
            this.firstName = first;
            this.lastName = last;
        }
        public Student(string first, string last, int grade, string school)
        {
            this.firstName = first;
            this.lastName = last;
            this.grade = grade;
            this.schoolName = school;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student Student1 = new Student();
    //        Student Student2 = new Student("Tom", "Jones");
    //        Student Student3 = new Student("Mike", "Myers", 5, "My School");
    //        //Student Student4 = new Student(,);
    //    }
    //}
}