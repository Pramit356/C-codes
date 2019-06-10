using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{

    public delegate void sumOfNum(int number1);
    class Program
    {

        public static bool isLeap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 00) || (year % 400 == 0))
                return true;
            else
                return false;
        }


        public static void Main()
        {
            Console.WriteLine("Enter a date: ");
            string inputDate = Console.ReadLine();
            string[] splitDate = inputDate.Split("/");
            Dictionary<int, Tuple<string, int>> monthInfo = new Dictionary<int, Tuple<string, int>>();

            monthInfo.Add(1, new Tuple<string, int>("January", 31));
            monthInfo.Add(2, new Tuple<string, int>("February", 28));
            monthInfo.Add(3, new Tuple<string, int>("March", 31));
            monthInfo.Add(4, new Tuple<string, int>("April", 30));
            monthInfo.Add(5, new Tuple<string, int>("May", 31));
            monthInfo.Add(6, new Tuple<string, int>("June", 30));
            monthInfo.Add(7, new Tuple<string, int>("July", 31));
            monthInfo.Add(8, new Tuple<string, int>("August", 31));
            monthInfo.Add(9, new Tuple<string, int>("September", 30));
            monthInfo.Add(10, new Tuple<string, int>("October", 31));
            monthInfo.Add(11, new Tuple<string, int>("November", 30));
            monthInfo.Add(12, new Tuple<string, int>("December", 31));

            string outMonth;


            int date = 0, month = 0, year = 0;

            if(!Int32.TryParse(splitDate[2], out year))
            {
                Console.WriteLine("Invalid year enterred! ");
                return;
            }


            if (Int32.TryParse(splitDate[1], out month))
            {
                if (month > 12 || month < 0)
                {
                    Console.WriteLine("Invalid month!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Not a valid month");
                return;
            }

            if (Int32.TryParse(splitDate[0], out date))
            {
                var dateInfo = monthInfo[month];
                if (month == 2 && !isLeap(year) && date > 28)
                {
                    Console.WriteLine("Invalid date");
                    return;
                }

                int maxDate = dateInfo.Item2;
                if (date > maxDate || date < 0)
                {
                    Console.WriteLine("Invalid date!");
                    return;
                }
                    
                outMonth = dateInfo.Item1;
            }
            else
            {
                Console.WriteLine("Not a valid date");
                return;
            }

            Console.WriteLine("The date is: " + date + "st " +outMonth+" " +year);
        }
       
    }
}
