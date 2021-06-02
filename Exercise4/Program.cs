using System;

namespace Exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",num,i,num*i);
            }
        }
    }
}