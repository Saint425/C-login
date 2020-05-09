using System;
using System.Globalization;


namespace time_date
{
    class Time
    {
        static void Main()
        {
            string user;
            Console.WriteLine("User Name: ");
            user = Console.ReadLine();
            Console.WriteLine("Hello, {0}", user);
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            Console.WriteLine("Current Time is {0}", localDate.ToString()); 
            Console.WriteLine("Current UTC Time is {0}", utcDate.ToString());
        }
}
}
