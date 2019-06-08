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
            Console.Write("Enter the number of rows: ");
            int prows = int.Parse(Console.ReadLine());
            int[,] arr = new int[prows, prows];

            for(int i = 0; i < prows; i++)
            {
                for(int k = prows-1; k > i; k--)
                {
                    Console.Write(" ");
                }

                for(int j = 0; j < i; j++)
                {
                    if (i == 0 || j == 0)
                        arr[i, j] = 1;
                    else
                        arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
