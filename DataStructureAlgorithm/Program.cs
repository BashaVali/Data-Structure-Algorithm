using System;
namespace DataStructureAlgorithm;
class Program
{
    public static string binaryTextPath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\Data-Structure-Algorithm\DataStructureAlgorithm\BinarySearch.txt";
    public static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\n\nWelcome to the Algorithm Programs " + "\n\n");

            Console.WriteLine(" Select the option ");

            Console.WriteLine("1.BinarySearch\n" +
                              "2.Exit" + "\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BinarySearch search = new BinarySearch();
                    search.ReadTextFile(binaryTextPath);
                    search.BinarySearchOperation("BinarySearch");
                    break;

                case 2:
                    flag = false;
                    break;
            }
        }
    }
}