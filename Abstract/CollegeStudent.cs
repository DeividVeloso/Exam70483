using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class CollegeStudent : Student
    {
        public string firstName;
        public string lastName;
        public string major;
        public double GPA;

        public override void outDetails()
        {
            Console.WriteLine("Yes - 2");
        }
    }
}
