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


            foreach (var name in result4)
            {
                Console.WriteLine(name);
            }
        } 
    }
}
