using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static bool checkAlternate(int num, int checkNum)
        {
            while (num != 0)
            {
                if (num % 2 == checkNum)
                {
                    num = num >> 1;
                    checkNum = (checkNum == 1) ? 0 : 1;
                }
                else
                    break;
            }
            if (num == 0)
                return true;
            else
                return false;
        }

        public static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool check;

            if (num % 2 == 0)
            {
                check = checkAlternate(num, 0);
            }
            else
            {
                check = checkAlternate(num, 1);
            }
            if (check == true)
                Console.WriteLine("The number is alternating.");
            else
                Console.WriteLine("The number is not alternating.");
        }
    }
}
