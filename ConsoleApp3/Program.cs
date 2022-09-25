using System;
using System.Linq;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] y = { 1, 35, 2, 4, 4, 3, 34, 33, 33 };

            Array.Sort(y);

            y = y.Distinct().ToArray();

            int count = 0;
            int maxCount = 0;
            int max = 0;
            int min = 0;

            for (int i = 0; i < y.Length-1; i++)
            {
                if(y[i]==y[i+1] - 1)
                {
                    count++;
                } else
                {
                    min = y[i - count];
                    max = y[i];
                    count = 0;
                }
                if(count > maxCount) 
                {
                    maxCount = count;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);


        }
    }
}
