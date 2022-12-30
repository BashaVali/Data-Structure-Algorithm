using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BalancedParanthesis
    {
        public void ReadTextFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(" ");
            LinkedListStack<string> LinkedListstack = new LinkedListStack<string>();
            foreach (var data in words)
            {
                if (data.Equals("("))
                    LinkedListstack.Push(data);
                if (data.Equals(")"))
                    LinkedListstack.Pop();
            }
            if (LinkedListstack.Peek())
            {
                Console.WriteLine("Arithmatic Expression is balanced");
            }
            else
                Console.WriteLine("Arithmatic Expression is not balanced");
        }
    }
}