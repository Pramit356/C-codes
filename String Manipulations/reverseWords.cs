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
            string[] eachword = str.Split();
            string outputString="";
            for(int i = eachword.Length-1; i >= 0; i--)
            {
                outputString += eachword[i] + " ";
            }
            Console.WriteLine(outputString);
        }
    }
}
