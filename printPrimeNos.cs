using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static void printPrime(int num)
        {
            for(int i = 2; i<=num; i++)
            {
                int num1 = Convert.ToInt32(Math.Sqrt(i));
                int isPrime = 1;
                for(int j = 2; j <= num1; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = 0;
                        break;
                    }
                }
                if (isPrime == 1)
                    Console.WriteLine(i);
            }
        }


        public static void Main()
        {
            Console.Write("Enter the number to find prime upto: ");
            int num = int.Parse(Console.ReadLine());

            printPrime(num);
        }
    }
}
