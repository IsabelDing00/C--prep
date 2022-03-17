using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTypes
{
    public class DataTypes
    {
        /*
        }*/
        public void practiceSizeAndRange()
        {
            // Composite Formatting to learn how to align text in a console application:https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting

            string name = "Fred";
            Console.WriteLine(String.Format("Name = {0}, hours = {1:hh}", name, DateTime.Now));

            string primes;
            primes = String.Format("Prime numbers less than 10: {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);

            string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
                                 "Ebenezer", "Francine", "George" };
            decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80,
                                         16.75m };

            Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
            for (int ctr = 0; ctr < names.Length; ctr++)
                Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);

            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "Type", "Size", "MIN", "MAX"));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "short", sizeof(short), short.MinValue, short.MaxValue));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "int", sizeof(int), int.MinValue, int.MaxValue));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "long", sizeof(long), long.MinValue, long.MaxValue));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "float", sizeof(float), float.MinValue, float.MaxValue));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "double", sizeof(double), double.MinValue, double.MaxValue));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-40} | {3, -10}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue));
        }

        public void convertCentriesToYears()
        {
            //2147483648         4294967295
            //1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes = 3155673600 seconds
            //= 3155673600000 milliseconds = 3155673600000000 microseconds = 3155673600000000000 nanoseconds
            //  3155673600                   3155673600000
            uint yearInCen = 100;
            float daysInYear = 365.24f;
            uint hoursInDay = 24;
            uint minutesInHours = 60;
            uint secondsInMin = 60;
            uint msInSecond = 1000;
            uint mcInMs = 1000;
            uint naInMc = 1000;

            Console.WriteLine("Enter centuries:");
            int cen = Convert.ToInt32(Console.ReadLine());
            long year = cen * yearInCen;
            float days = year * daysInYear;
            float hours = days * hoursInDay;
            float minutes = hours * minutesInHours;
            long seconds = (long)(minutes * secondsInMin);
            long milliseconds = (long)(seconds * msInSecond);
            long microseconds = (long)(milliseconds * mcInMs);
            long nanosecond = (long)(microseconds * naInMc);

            Console.WriteLine($"{cen} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanosecond} nanoseconds");
        }
    }
}
