//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace DataStructurePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrimeNumbersWithinRange.PrimeNumbers();
        }
        public class PrimeNumbersWithinRange
        {
            public static void PrimeNumbers()
            {

                int num, i, ctr, stno, enno;

                Console.Write("\n\n");
                Console.Write("Find the prime numbers within a range of numbers:\n");
                Console.Write("---------------------------------------------------");
                Console.Write("\n\n");

                Console.Write("Input starting number of range: ");
                stno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input ending number of range : ");
                enno = Convert.ToInt32(Console.ReadLine());
                Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

                for (num = stno; num <= enno; num++)
                    if (num == 0)
                    { Console.WriteLine("Zero is not a prime number"); }
                    else
                    {
                        ctr = 0;

                        for (i = 2; i <= num / 2; i++)
                        {
                            if (num % i == 0)
                            {
                                ctr++;
                                break;
                            }
                        }

                        if (ctr == 0 && num != 1)
                            Console.Write("{0} ", num);
                    }
                Console.Write("\n");
            }






        }
    }
}