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
            Console.WriteLine("Welcome to the Algorithm Programs ");

            Console.WriteLine(" Select the option ");

            Console.WriteLine("1.BinarySearch \n2.InsertionSort \n3.BubbleSort \n4.Anagram \n5.UserInput \n6.Exit ");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BinarySearch search = new BinarySearch();
                    search.ReadTextFile(binaryTextPath);
                    search.BinarySearchOperation("BinarySearch");
                    break;
                case 2:
                    int[] arr = { 2, 1, 3 };
                    InsertionSort insertion = new InsertionSort();
                    insertion.Sort(arr);
                    break;
                case 3:
                    int[] arr2 = { 5, 2, 1, 4, 3 };
                    BubbleSort bubble = new BubbleSort();
                    bubble.Sort(arr2);
                    break;
                case 4:
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram("Heart", "Earth");
                    break;
                case 5:
                    UserInput userInput = new UserInput();
                    userInput.ReplaceString();
                    break;

                case 6:
                    flag = false;
                    break;
            }
        }
    }
}