//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace DataStructurePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {

          
            {
                string str = "ABC";
                char[] charArry = str.ToCharArray();
                Permute(charArry, 0, 2);
                Console.ReadKey();
            }

            static void Permute(char[] arry, int i, int n)
            {
                int j;
                if (i == n)
                    Console.WriteLine(arry);
                else
                {
                    for (j = i; j <= n; j++)
                    {
                        Swap(ref arry[i], ref arry[j]);
                        Permute(arry, i + 1, n);
                        Swap(ref arry[i], ref arry[j]); //backtrack
                    }
                }
            }

            static void Swap(ref char a, ref char b)
            {
                char tmp;
                tmp = a;
                a = b;
                b = tmp;
            }
        }
    }
}