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
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int max = 0, count = 0;
            string word = "", maxWord="";
            for(int i = 0; i < str.Length; i++)
            {
                if (Char.IsWhiteSpace(str[i]) || i==str.Length-1)
                {
                    if (count > max)
                    {
                        max = count;
                        maxWord = word;
                    }
                    count = 0;
                    word = "";
                }
                else
                {
                    count++;
                    word += str[i];
                }
            }
            Console.WriteLine("The maximum lengthed word is {0} with a length of {1} ", maxWord, max);
            
        }
    }
}
