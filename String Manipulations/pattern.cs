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

            Console.Write("Enter the input string: ");
            string input = Console.ReadLine().ToLower();
            Console.Write("Enter the word whose instance is to be counted: ");
            string word = Console.ReadLine().ToLower();
            int count1 = countM1(input, word);
            int count2 = countM2(input, word);


            Console.WriteLine("By method 1: " + count1);
            Console.WriteLine("By method 2: " + count2);
        }

        public static int countM1(string userInput, string instance)
        {
            string[] splitData = userInput.Split();
            int count = 0;
            for(int i = 0; i < splitData.Length; i++)
            {
                if (splitData[i] == instance)
                    count++;
            }
            return count;
        }
        
        public static int countM2(string userInput, string instance)
        {
            int count = 0, cnt = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                //Console.WriteLine(cnt);
                if (userInput[i] == instance[cnt])
                    cnt++;
                else
                    cnt = 0;

                if (cnt == instance.Length)
                {
                    count++;
                    cnt = 0;
                }

                
            }
            return count;
        }
    }
}
