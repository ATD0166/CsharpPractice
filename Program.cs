using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXTEND METHOD TEST
            string text = "Text";
            Console.WriteLine(text.PickInitial());
            Console.WriteLine();


            List<Student> students = Student.GetAllStudents();


            // LINQ AGGRECATE OPERATORS
            //MAX
            double maxPoint = students.Max(stu => stu.Point);                            
            Console.WriteLine($"本班最高分 : {maxPoint}");
            Console.WriteLine();

            //MIN
            double minPoint = students.Min(stu => stu.Point);
            Console.WriteLine($"本班最低分 : {minPoint}");
            Console.WriteLine();

            //SUM
            double sum = students.Sum(stu => stu.Point);
            Console.WriteLine($"全班總分 : {sum}");
            Console.WriteLine();

            //AVERAGE
            double average = students.Average(stu => stu.Point);
            Console.WriteLine($"本班平均分數 : {average}");
            Console.WriteLine();

            //COUNT
            int numofPass = students.Where(stu => stu.Point > 59).Count();
            Console.WriteLine($"本班及格人數 : {numofPass}");
            Console.WriteLine();


            //LINQ PROJECTION OPERATORS
            //SELECT
            var ids = students.Where(stu => stu.Point > 59).Select(stu => stu);
            Console.WriteLine("及格者 : ");
            foreach (var item in ids)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();

            //SELECTMANY
            var stuAbility =  students.SelectMany(stu => stu.Ability,  (student, ability) => new { Name = student.Name, Ability = ability});
            Console.WriteLine("學生技能");
            foreach (var item in stuAbility)
            {
                Console.WriteLine($"{item.Name} : {item.Ability}");
            }
            Console.WriteLine();

            //DISTINCT
            var allAbility = students.SelectMany(stu => stu.Ability).Distinct();
            Console.WriteLine("學生技能列表");
            foreach (var item in allAbility)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();


            //ORDERING OPERATORS
            //ORDERBY
            Console.WriteLine("成績由低到高");
            var sortByAsc = students.OrderBy(stu => stu.Point);
            foreach (var item in sortByAsc)
            {
                Console.WriteLine($"{item.Name} : {item.Point}");
            }
            Console.WriteLine();

            //ORDERBYDESCENDING
            Console.WriteLine("成績由高到低");
            var sortByDes = students.OrderByDescending(stu => stu.Point);
            foreach (var item in sortByDes)
            {
                Console.WriteLine($"{item.Name} : {item.Point}");
            }
            Console.WriteLine();

            //THEN & THENBYDESCENDING
            Console.WriteLine("成績由低到高，座號由高到低");
            var sortByMulti = students.OrderBy(stu => stu.Point).ThenByDescending(stu => stu.ID);
            foreach (var item in sortByMulti)
            {
                Console.WriteLine($"{item.ID} : {item.Name} : {item.Point}");
            }
            Console.WriteLine();


            //PARTITIONING OPERATOR
            //TAKE
            Console.WriteLine("Take 3");
            var takeOp = students.Take(3);
            foreach (var item in takeOp)
            {
                Console.WriteLine($"{item.ID} : {item.Name}");
            }
            Console.WriteLine();

            //TAKEWHILE
            Console.WriteLine("Take while ID < 103");
            var takeWhileOp = students.TakeWhile(stu => stu.ID < 103);
            foreach (var item in takeWhileOp)
            {
                Console.WriteLine($"{item.ID} : {item.Name}");
            }
            Console.WriteLine();

            //SKIP
            Console.WriteLine("Skip 2 ");
            var skipOp = students.Skip(2);
            foreach (var item in skipOp)
            {
                Console.WriteLine($"{item.ID} : {item.Name}");
            }
            Console.WriteLine();

            //SKIPWHILE
            Console.WriteLine("Skip while ID < 104");
            var skipWhileOp = students.SkipWhile(stu => stu.ID < 104);
            foreach (var item in skipWhileOp)
            {
                Console.WriteLine($"{item.ID} : {item.Name}");
            }
            Console.WriteLine();


            //CONVERSION OPRATORS
            //ToList
            var toList = students.ToList();

            //ToArray
            var toArr = students.ToArray();

            //ToDictionary
            Console.WriteLine("To Dictionary");
            var toDic = students.ToDictionary(k => k.ID, v => v.Name); /* 前項為key，後項為value。後項可省略，若省略則value為student */
            foreach (var item in toDic)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();

            //ToLookup
            Console.WriteLine("To Lookup");
            var abi = students.SelectMany(stu => stu.Ability, (students, ability) => new { Name = students.Name, Ability = ability });
            var toLookup = abi.ToLookup(k => k.Ability); /* 與dictionary類似，但lookup的key值可以重複，dictionary不行 */
            foreach (var item in toLookup)
            {
                Console.WriteLine(item.Key);
                foreach (var value in toLookup[item.Key])
                {
                    Console.WriteLine($"\t{value.Name}");
                }
            }
            Console.WriteLine();

            //Cast : 若cast型別不合的物件，會在該物件被執行時出現exception
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("two");
            list.Add(3);
            list.Add("four");
            IEnumerable<int> castInts = list.Cast<int>();
            
            //foreach (int? item in castInts)
            //{
            //    Console.WriteLine(item);
            //}

            //OfType : 在映射時會直接跳過型別不合的物件，故執行時不會出現exception 
            IEnumerable<int> oftypeInts = list.OfType<int>();
            foreach (var item in oftypeInts)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
