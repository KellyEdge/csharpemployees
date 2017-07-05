using System;
using System.Collections.Generic;

namespace csharpemployees
{
    internal class Employee
    {
        private string empName = "unknown";
        private int empAge = 0;

        public string Name
        {
            get 
            {
                return empName; 
            }
            set 
            {
                empName = value; 
            }
        }
        
        public int Age
        {
            get 
            { 
                return empAge; 
            }
            set 
            { 
                empAge = value; 
            }
        }
        
        public static void Main(string[] args)
        {
            // Create a new Employee object:
            Employee employee = new Employee();

            employee.Name = "Kelly";
            employee.Age = 37;
            
            Console.WriteLine(employee.empName + " " + employee.empAge);
        } 
    }
}