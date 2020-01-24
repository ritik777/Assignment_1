using System;

namespace Assignment_1
{
    class Program
    {
        private static void PrintPattern(int n)
        {
            int i, j, q;
            for (i = n; i >= 1; i--)
            {

                for (j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine(" ");
                n--;
            }

        }
        static void Main(string[] args)
        {
            PrintPattern(5);
        }
    }
}
