using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {

        public static void Main()
        {
            Console.Write("Enter the three numbers: ");
            string[] stringArray = Console.ReadLine().Split();
            int[] threenumbers = Array.ConvertAll(stringArray, s=>int.Parse(s));
            int a, b, c;
            a = threenumbers[0];
            b = threenumbers[1];
            c = threenumbers[2];

            int max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);

            Console.WriteLine("Maximum number is " + max);
        }
    }
}
