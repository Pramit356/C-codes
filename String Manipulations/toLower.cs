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
            StringBuilder equivalentStr = new StringBuilder(str);
            for(int i = 0; i < str.Length; i++)
            {
                if (equivalentStr[i] < (char)97)
                {
                    //int temp = equivalentStr[i];
                    //temp += 32;
                    //equivalentStr[i] = (char)temp;

                    equivalentStr[i] = (char)((int)equivalentStr[i] + 32);
                }
            }
            Console.WriteLine("All lower case: " + equivalentStr);
            
        }
    }
}
