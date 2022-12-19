using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class UserInput
    {
        public void ReplaceString()
        {
            string input = "Hello <<name>>.we have your Fullname as  <<FullName>> in our System.Your contact number is 91-xxxxxxxxxx.";
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            input = input.Replace("<<name>>", name);
            Console.WriteLine("Enter Full Name");
            string fullName = Console.ReadLine();
            input = input.Replace("<<FullName>>", fullName);
            Console.WriteLine("Enter Mobile Number");
            string mobile = Console.ReadLine();
            input = input.Replace("xxxxxxxxx", mobile);
            Console.WriteLine(input);

        }
    }
}