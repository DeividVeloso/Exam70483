﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsAndIs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array of Employees.
            Employee[] employees = new Employee[10];
            for (int id = 0; id < employees.Length; id++)
                employees[id] = new Employee();
            // Implicit cast to an array of Persons.
            // (An Employee is a type of Person.)
            Person[] persons = employees;
            // Explicit cast back to an array of Employees.

            // (The Persons in the array happen to be Employees.)
            employees = (Employee[])persons;
            // Use the is operator.
            if (persons is Employee[])
            {
            // Treat them as Employees.
            //...
            }
            // Use the as operator.
            employees = persons as Employee[];
            // After this as statement, managers is null.
            Manager[] managers = persons as Manager[];
            // Use the is operator again, this time to see
            // if persons is compatible with Manager[].
            if (persons is Manager[])
            {
            // Treat them as Managers.
            //...
            }
            // This cast fails at run time because the array
            // holds Employees not Managers.
            managers = (Manager[])persons;
        }
    }
}
