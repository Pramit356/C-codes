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
            ATM Transaction = new ATM();
            Console.WriteLine("Please enter your choice: \n1-> Balance checking \n2-> Cash withdraw \n3-> Cash deposit");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Your balance is {0}", Transaction.balanceCheck());
                    break;
                case 2:
                    Transaction.cashWithdraw();
                    break;
                case 3:
                default:
                    Console.WriteLine("Typo mistake");
                    break;
            }
        }
        
    }

    class ATM
    {
        private Dictionary<int, Tuple<string, int>> data = new Dictionary<int, Tuple<string, int>>
        {
            {1,  Tuple.Create("Pramit" , 2000) },
            {2,  Tuple.Create("Akash" , 5000) },
            {4,  Tuple.Create("Solsi" , 10000) },
            {7,  Tuple.Create("Fred" , 1000) },
            {11,  Tuple.Create("Jonas" , 2000) },
        };

        public int balanceCheck()
        {
            Console.Write("Please enter your ID: ");
            string inputUser = Console.ReadLine(); 
            int ID = 0;
            bool check = int.TryParse(inputUser, out ID);

            if (!check)
            {
                Console.WriteLine("OOPS wrong PIN format");
                System.Environment.Exit(0);
            }
            var userData = data[ID];
            return userData.Item2;
        }

        public void cashWithdraw()
        {
            Console.Write("Please enter your ID: ");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("How much do you wish to withdraw?: ");
            int money = int.Parse(Console.ReadLine());

            int available = data[ID].Item2;
            if (available < money)
                Console.WriteLine("Insufficient cash");
            else
            {
                string name = data[ID].Item1;
                Console.WriteLine("Money debited sucessfully");
                Console.WriteLine("Thank you for the transaction " + name + " Cash left = " + (available - money));
                data[ID] = Tuple.Create(name, available - money);
            }

        }

        public void cashDeposit()
        {
            Console.Write("Please enter your ID: ");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("How much do you wish to withdraw?: ");
            int money = int.Parse(Console.ReadLine());

            int available = data[ID].Item2;
            string name = data[ID].Item1;
            Console.WriteLine("Money credited sucessfully");
            Console.WriteLine("Thank you for transaction " + name + " Cash in account = " + (available + money));
            data[ID] = Tuple.Create(name, available + money);
           
        }

    }
}
