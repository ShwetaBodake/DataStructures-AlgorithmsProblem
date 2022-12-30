//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace DataStructurePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {

            InsertionSort sort = new InsertionSort();
            sort.DisplayInsertionSort();

            BubbleSort sort1 = new BubbleSort();
            sort1.DisplayBubbleSort();

            Anagram.isAnagram();



        }
    }
}