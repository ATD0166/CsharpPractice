using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        static public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee
                {
                    Name = "John",
                    Gender = "Male",
                    Salary = 45000,
                    Department = "HR"
                },

                new Employee
                {
                    Name = "Mary",
                    Gender = "Female",
                    Salary = 50000,
                    Department = "HR"
                },

                new Employee
                {
                    Name = "Velonica",
                    Gender = "Female",
                    Salary = 78000,
                    Department = "IT"
                },

                new Employee
                {
                    Name = "Martin",
                    Gender = "Male",
                    Salary = 80000,
                    Department = "IT"
                },

                new Employee
                {
                    Name = "Thomas",
                    Gender = "Male",
                    Salary = 71000,
                    Department = "IT"
                },

                new Employee
                {
                    Name = "Harley",
                    Gender = "Female",
                    Salary = 71000,
                    Department = "IT"
                },

                new Employee
                {
                    Name = "Ashley",
                    Gender = "Female",
                    Salary = 35000,
                    Department = "HR"
                }
            };
            return employees;
        }
    }
}
