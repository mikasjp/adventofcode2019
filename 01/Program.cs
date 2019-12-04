using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2019
{
    class Program
    {
        public static void Main()
        {
            Func<double, double> func = x => Math.Floor(x / 3) - 2.0;
            var input = File.ReadAllText("./input.txt")
              .Split(Environment.NewLine)
              .Select(double.Parse);

            // First part
            var first = input.Sum(func);
            Console.WriteLine($"First part:\t{first}");

            // Second part
            var second = input
              .Sum(x =>
              {
                  var sum = func(x);
                  var add = sum;
                  while (add > 0)
                  {
                      add = new[] { 0, func(add) }.Max();
                      sum += add;
                  }
                  return sum;
              });
            Console.WriteLine($"Second part:\t{second}");
        }
    }
}
