//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classes
//{

//    // create a class called Student
//    private class Student
//    {
//        private static int StudentCount;
//        private string firstName;
//        private string lastName;
//        private string grade;

//        private string concatenateName()
//        {
//            string fullName = this.firstName + " " + this.lastName;
//            return fullName;
//        }
//        private void displayName()
//        {
//            string name = concatenateName();
//            Console.WriteLine(name);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Student firstStudent = new Student();
//            Student.StudentCount++;

//            Student secondStudent = new Student();
//            Student.StudentCount++;
            
//            firstStudent.firstName = "John";
//            firstStudent.lastName = "Smith";
//            firstStudent.grade = "six";
            
//            secondStudent.firstName = "Tom";
//            secondStudent.lastName = "Thumb";
//            secondStudent.grade = "two";
            
//            Console.WriteLine(firstStudent.firstName);
            
//            Console.WriteLine(secondStudent.firstName);
            
//            Console.WriteLine(Student.StudentCount);

//            firstStudent.displayName();
//        }
//    }
//}
