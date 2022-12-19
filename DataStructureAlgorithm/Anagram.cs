using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class Anagram
    {
        public void CheckAnagram(String inputStr1, String inputStr2)
        {
            String input1 = Test(inputStr1);
            String input2 = Test(inputStr2);
            if (input1.Equals(input2))
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Not a Anagram");
        }
        public String Test(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
    }
}