using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int number, i, k;
            Console.Write("Enter number of rows: ");
            number = int.Parse(Console.ReadLine());
            int count = number - 1;
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
