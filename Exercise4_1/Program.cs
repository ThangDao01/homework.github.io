using System;

namespace Exercise4_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your phone");
            string phone = Console.ReadLine();
            Console.WriteLine("Name : {0} \n Address : {1} \n Phone : {2}",name,address,phone);
        }
    }
}