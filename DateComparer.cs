using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        public static bool isLeap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 00) || (year % 400 == 0))
                return true;
            else
                return false;
        }

        public static string compareDates(int d1, int d2, int m1, int m2, int y1, int y2)
        {
            if (y1 > y2)
                return "first";
            else if (y1 < y2)
                return "second";
            else
            {
                if (m1 > m2)
                    return "first";
                else if (m1 < m2)
                    return "second";
                else
                {
                    if (d1 > d2)
                        return "first";
                    else if (d1 < d2)
                        return "second";
                    else
                        return "The dates are equal";
                }
            }
        }


        public static int countDays(string[] first, string[] second, Dictionary<int, int> monthInfo)
        {
            int d1, d2, m1, m2, y1, y2, days = 0, noDays;
            d1 = int.Parse(first[0]);
            d2 = int.Parse(second[0]);
            m1 = int.Parse(first[1]);
            m2 = int.Parse(second[1]);
            y1 = int.Parse(first[2]);
            y2 = int.Parse(second[2]);

            while(d1 != d2)
            {
                if (d1 < d2)
                {
                    noDays = monthInfo[m2];
                    if (isLeap(y2) && m2 == 2)
                        noDays += 1;
                    if (d2 != noDays)
                    {
                        days = days + noDays - d2;
                    }
                    d2 = 1;
                    if (m2 == 12)
                    {
                        m2 = 1;
                        y2 += 1;
                    }
                    else
                        m2 += 1;
                }
                else
                {
                    days = days + d1 - d2;
                    d2 = d1;
                } 
            }

            while (m1 != m2)
            {
                if (isLeap(y2) && m2 == 2)
                    days += 1;
                days += monthInfo[m2];
                if (m2 < 12)
                {
                    m2 += 1;
                }
                else
                {
                    m2 = 1;
                    y2 += 1;
                }
            }


            while (y1 != y2)
            {
                if (isLeap(y2))
                    days += 366;
                else
                    days += 365;
                y2 += 1;
            }
            return days;
        }
            

        public static void Main()
        {
            Console.WriteLine("Enter the first date: ");
            string[] Date1 = Console.ReadLine().Split("/");

            Console.WriteLine("Enter the second date: ");
            string[] Date2 = Console.ReadLine().Split("/");

            Dictionary<int, int> monthInfo = new Dictionary<int, int>();

            monthInfo.Add(1, 31);
            monthInfo.Add(2, 28);
            monthInfo.Add(3, 31);
            monthInfo.Add(4, 30);
            monthInfo.Add(5, 31);
            monthInfo.Add(6, 30);
            monthInfo.Add(7, 31);
            monthInfo.Add(8, 31);
            monthInfo.Add(9, 30);
            monthInfo.Add(10, 31);
            monthInfo.Add(11, 30);
            monthInfo.Add(12, 31);

            int d1, d2, m1, m2, y1, y2;
            d1 = int.Parse(Date1[0]);
            d2 = int.Parse(Date2[0]);
            m1 = int.Parse(Date1[1]);
            m2 = int.Parse(Date2[1]);
            y1 = int.Parse(Date1[2]);
            y2 = int.Parse(Date2[2]);

            int noOfDays = 0;

            string result = compareDates(d1, d2, m1, m2, y1, y2);
            if (result == "first")
                noOfDays = countDays(Date1, Date2, monthInfo);
            else if (result == "second")
                noOfDays = countDays(Date2, Date1, monthInfo);
            else
                noOfDays = 0;


            Console.WriteLine("The number of days between the 2 inputs = {0}", noOfDays);
        }
       
    }
}
