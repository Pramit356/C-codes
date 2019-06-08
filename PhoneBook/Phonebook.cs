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
            Hashtable ht = new Hashtable();
            string path = @"C:\Users\Owner\source\repos\ConsoleApp1\ConsoleApp1\phoneData.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string Data = "";
                while ((Data = sr.ReadLine()) != null)
                {
                    string[] eachData = Data.Split();
                    string fullName = eachData[0] + eachData[1];
                    long phone = Convert.ToInt64(eachData[2]);

                    ht.Add(phone, fullName);
                }
            }
            Console.Write("Entry into the Phonebook successful. Press any key: ");
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("Enter the phone no: ");
            long inputNo = Convert.ToInt64(Console.ReadLine());

            if (ht[inputNo] != null)
                Console.WriteLine("The name of the person is: " + ht[inputNo]);
            else
                Console.WriteLine("No person exists in the phonebook with this phone number.");
        }
    }
}
