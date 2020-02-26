using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPracticeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ TEST
            int[] numbers = new int[] { 1,2,3,5,15,22,51,98};

            int max = numbers.Max();

            int maxofeven = numbers.Where(num => num % 2 == 0).Max();

            // Lambda寫法
            IEnumerable<int> evens = numbers.Where(num => num % 2 == 0);

            // 類SQL寫法
            IEnumerable<int> odds = from nums in numbers 
                                    where  nums % 2 != 0 
                                    select nums;
            
            foreach (var item in odds)
            {
                Console.WriteLine(item);
            }



            // EXTEND METHOD TEST
            string text = "Text";
            Console.WriteLine(text.PickInitial());            
        }
    }
}
