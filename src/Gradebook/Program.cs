using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
         static void Main(string[] args)
        {
            var book = new Book("Warren's grade Book");
            book.AddGrade(80.2);
            book.AddGrade(70);
            book.AddGrade(90);

            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The highest grade is {stats.High:N2}");
            Console.WriteLine($"The lowest grade is {stats.Low:N2}");
        }

    }
}
