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
            get { return empName; }
            set { empName = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public static void Main(string[] args)
        {

            int empNo = 1;
            string newEmpName = "unknown";
            int newEmpAge = 0;

            while (empNo < 5)
            {
                Employee newEmployee = new Employee();
                
                Console.WriteLine("Please enter a name for Employee " + empNo);
                newEmpName = Console.ReadLine();
                newEmployee.Name = newEmpName;
                
                Console.WriteLine("Please enter an age for Employee " + empNo);
                newEmpAge = int.Parse(Console.ReadLine());
                newEmployee.Age = newEmpAge;
                
                Console.WriteLine("New Employee: " + newEmployee.Name + " " + newEmployee.Age);
                ++empNo;
            }

            /* // Create a new Employee object:
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            
            employee1.Name = "Kelly";
            employee1.Age = 37;
            employee2.Name = "Wes";
            employee2.Age = 40;

            Console.WriteLine("Employee1: " + employee1.empName + " " + employee1.empAge);
            Console.WriteLine("Employee2: " + employee2.empName + " " + employee2.empAge);
            
            string newName = "";
            
            Console.WriteLine("Please choose a new name for Employee1.");
            newName = Console.ReadLine();

            
           if (newName == employee1.Name)
                Console.WriteLine("That name was chosen already. Please choose a new name.");
            else
            {
                employee1.Name = newName;
                Console.WriteLine("new name = " + employee1.Name);
                //Console.ReadLine();
            }*/
        }
    }
}