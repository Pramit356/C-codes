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
            string path = @"C:\Users\Owner\source\repos\ConsoleApp1\ConsoleApp1\testFile.txt";
            FileInfo finfo = new FileInfo(path);
            Console.WriteLine("Length of the file is {0}", finfo.Length.ToString());
        }
    }
}
