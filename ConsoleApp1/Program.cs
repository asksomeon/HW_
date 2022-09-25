using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(
            String.Concat(Console.ReadLine().ToLower().OrderBy(ch => ch))
            .Equals(String.Concat(Console.ReadLine().ToLower().OrderBy(ch => ch))) ? "Yes" : "No");

        }
    }
}
