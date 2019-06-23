using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wnesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            Console.WriteLine("Before:");
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            daysOfWeek[2] = "Wednesday";

            Console.WriteLine("\r\nAfter:");
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
