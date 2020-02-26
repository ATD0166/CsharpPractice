using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    class Student
    {
        public string Name { get; set; }
        public int ID  { get; set; }
        public double Point { get; set; }
        public string[] Ability { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> stus = new List<Student>()
            {
                new Student()
                {
                    Name = "Sam",
                    ID = 101,
                    Point = 57,
                    Ability = new string[] { "JAVA", "Python", "C#" }
                },

                new Student()
                {
                    Name = "Edward",
                    ID = 102,
                    Point = 92,
                    Ability = new string[] { "Alchemy", "CQC", "Math"}
                },

                new Student()
                {
                    Name = "Wendy",
                    ID = 103,
                    Point = 76,
                    Ability = new string[] { "Mechanic", "Boxing", "Drawing"}
                },

                new Student()
                {
                    Name = "Asato",
                    ID = 104,
                    Point = 65,
                    Ability = new string[] { "Dreaming", "Drawing", "Writing" }
                }
            };

            return stus;
        }
    }
}
