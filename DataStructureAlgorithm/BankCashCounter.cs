using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    internal class BankCashCounter
    {
        BankQueue<string> queue;
        int totalAmount;
        public void ReadAllTextFile(string filepath)
        {
            string line = File.ReadAllText(filepath);
            string[] words = line.Split(",");
            queue = new BankQueue<string>();
            foreach (var word in words)
            {
                queue.Enqueue(word);
            }
            queue.Display();
            Console.Write("Total Amount Available in Bank Initially :");
            totalAmount = Convert.ToInt32(Console.ReadLine());
            foreach (var word in words)
            {
                Console.WriteLine("Welcome To Bank Cash Counter Statement");
                Console.WriteLine("\nSelect The Option \n1.Deposit Amount\n2.Withdraw Amount");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Deposit();
                        break;
                    case 2:
                        Withdraw();
                        break;
                }
            }
            Console.WriteLine("cash available in Bank: " + totalAmount);
        }
        public void Deposit()
        {
            Console.Write("Enter the amount you want to Deposit: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            totalAmount += deposit;
            queue.Dequeue();
        }
        public void Withdraw()
        {
            Console.Write("Enter the amount you want to Withdraw: ");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            if (totalAmount > withdraw)
            {
                if (withdraw <= 20000)
                {
                    totalAmount -= withdraw;
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("InsufficientBalance.Try Again");
                    Withdraw();
                }
            }
        }
    }
}

