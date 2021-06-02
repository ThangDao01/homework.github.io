using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[3];
            int max=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine("{0}",max);
        }
    }
}