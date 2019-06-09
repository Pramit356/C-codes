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
        public static string stringSwap1(string userInput)
        {
            string str1 = char.ToString(userInput[userInput.Length - 1]);
            char temp = userInput[0];

            for (int i = 1; i < userInput.Length; i++)
            {
                if (i == userInput.Length - 1)
                    str1 += char.ToString(temp);
                else
                    str1 += userInput[i];
            }

            return str1;
        }


        public static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string str1 = stringSwap1(str);
            
            Console.WriteLine("Output string = " + str1);

            StringBuilder str2 = new StringBuilder(str);
            char temp = str2[0];
            str2[0] = str2[str2.Length-1];
            str2[str2.Length - 1] = temp;
            Console.WriteLine();
            Console.WriteLine("Using StringBuilder, After Swapping: "+str2);
        }
    }
}
