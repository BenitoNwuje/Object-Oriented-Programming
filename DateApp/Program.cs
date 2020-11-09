using System;
using System.Globalization;

namespace DateApp
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello");

            DateTime now = DateTime.Now;
             int month = int.Parse(Console.ReadLine());
             int day = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DateTime birthdayThisYear = new DateTime(year, month, day);
            TimeSpan diff = birthdayThisYear - now;

            DateTime nextBirthday;
            if (now < new DateTime(now.Year, month, day))
            {
                nextBirthday = new DateTime(now.Year, month, day);
            }
            else
            {
                new DateTime(now.Year + 1, month, day);
            }
           
             Console.WriteLine($"Er zij nog {diff.Days} dagen tot je verjaardag");

            /*
             DateTime dt = DateTime.Now;
        
             Console.WriteLine(dt.ToString());
             Console.WriteLine(dt.ToString("d"));
             Console.WriteLine(dt.ToString("dddd, dd MMMM yyyy"));
             Console.WriteLine($"{dt:mm/dd/yyyy}");
             CultureInfo russianCI = new CultureInfo("ru-RU");
             CultureInfo frenchCI  = new CultureInfo("fr-FR");
             Console.WriteLine(dt.ToString("f", frenchCI));
             Console.WriteLine($"{dt.ToString("f",frenchCI)}");
             Console.WriteLine(dt.ToString("r", russianCI));
             Console.WriteLine($"{dt.ToString("r", russianCI)}"); */

            DateTime today = DateTime.Now;
            bool isLeap = DateTime.IsLeapYear(today.Year);
            if (isLeap == true)
            {
                Console.WriteLine("This year is a leap year");
            }

            
            


        }
    }
}
