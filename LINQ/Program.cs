using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            // LINQ - Language Integrated Query
            // LINQ to objects

            int[] numbers = { 23, 44, 87, 97, 44, 84, 10, 88, 55, 79, 88, 78, 45, 49 };

            // Fetch numbers which are greater than 50 and less than 70

            // Using nethod syntax - lambda expression
            var result1 = numbers.Where(x => x > 50 && x < 70);

            // Using sql query syntax - Query expression
            var result2 = from num in numbers
                          where num > 50 && num < 70
                          select num;


            string[] names = { "ram", "shyam", "abc", "ramesh", "virat", "ronaldo", "Rakesh" };

            // Names having length greater than 3 and starts with letter 'R'
            var result3 = names.Where(x => x.Length > 3 && x.ToUpper().StartsWith("R"));

            var result4 = from name in names
                          where name.Length > 3 && name.ToLower().StartsWith("r")
                          select name;

            // Projections
            // Squaring of all numbers
            var result5 = numbers.Select(x => x * x);

            // This can also be done using query expression as:
            // var result5 = from num in numbers   
            //                 select num*num;

            // Ordering
            var result6 = from num in result5
                          orderby num
                          select num;

            // Take first 5 elements
            var result7 = numbers.Take(5);

            // Skip first 5 and take next 5
            var result7b = numbers.Skip(5).Take(5);

            // Quantifier
            var result8 = numbers.Any(x => x % 2 == 0);
            var result9 = numbers.All(x => x % 2 == 0);
            var result10 = numbers.Contains(44);
            Console.WriteLine(result10);

            var result11 = Enumerable.Range(1, 1000);
            var result12 = Enumerable.Repeat("Hello World", 10);

            foreach (var num in result12)
            {
                Console.WriteLine(num);
            }

            ComplexType complexType = new ComplexType();
            complexType.LearnLINQ();
        }
    }
}
