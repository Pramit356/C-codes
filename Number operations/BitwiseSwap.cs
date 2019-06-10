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

            Console.Write("Enter the two numbers (i and j): ");
            string[] input = Console.ReadLine().Split();
            int i = int.Parse(input[0]);
            int j = int.Parse(input[1]);
            Console.WriteLine("Before swapping, i = {0} and j = {1}", i, j);

            i = i ^ j;
            j = i ^ j;
            i = i ^ j;
            Console.WriteLine("After swapping, i = {0} and j = {1}", i, j);
        }
    }
}
