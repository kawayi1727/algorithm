using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

        }

        public int[] InsertionSort(int[] s)
        {

            {
                for (int i = 0; i < s.Length - 1;)
                {
                    int b = s[i + 1];
                    int j = i;
                    while (j >= 0 && s[j] > b)
                    {
                        s[j + 1] = s[j];
                        j--;
                    }
                    s[j + 1] = b;
                    Console.WriteLine();
                    Console.ReadKey();
                }
                return s;
            }
         
        }
    }
}