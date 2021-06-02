using System;
namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("Enter your day (1-7)");
        int day = Convert.ToInt32(Console.ReadLine());      
        DateTime dt = new DateTime(2021, 5, 2+day);
        Console.WriteLine("The day of the week for is {0}.", dt.DayOfWeek);
        }
    }
}