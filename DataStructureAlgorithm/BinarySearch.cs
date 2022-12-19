using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
        public class BinarySearch
        {
            string[] binaryArray;
            public void ReadTextFile(string filepath)
            {
                string words = File.ReadAllText(filepath);
                binaryArray = words.Split(",");
            }
            public void BinarySearchOperation(string input)
            {
                foreach (var word in binaryArray)
                {
                    if (word.Equals(input))
                    {
                        Console.WriteLine("Found the Word in the List Using Binary Search");
                        return;
                    }
                }
                Console.WriteLine("search element is not available in the list of words");
            }
        }
    }