using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
DateTime now = DateTime.Now;

Console.WriteLine("Today's date: {0}", now.Date);
Console.WriteLine("Today is {0} day of {1}", now.Day, months[now.Month - 1]);
Console.WriteLine("Today is {0} day of {1}", now.DayOfYear, now.Year);
Console.WriteLine("Today's time: {0}", now.TimeOfDay);
Console.WriteLine("Hour: {0}", now.Hour);
Console.WriteLine("Minute: {0}", now.Minute);
Console.WriteLine("Second: {0}", now.Second);
Console.WriteLine("Millisecond: {0}", now.Millisecond);
Console.WriteLine("The day of week: {0}", now.DayOfWeek);
Console.WriteLine("Kind: {0}", now.Kind);
*/

namespace UnderstandingTypes
{
    public class LoopsAndOperators
    {
        public void fizzBuzz()
        {
            for (int i = 1; i <= 100; i ++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void e()
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                checked
                {
                    Console.WriteLine(i);
                }
                // this doesn't work 
            }
        }

        public void guessNum()
        {
            int correctNumber = new Random().Next(3) + 1;

            Console.WriteLine("Guess number:");
            int num = int.Parse(Console.ReadLine());

            if (num == correctNumber)
            {
                Console.WriteLine("You are right!");
            }
            else if (num > 3 || num < 1)
            {
                Console.WriteLine("Number out of range");
            }
            else if (num > correctNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Too low");
            }
        }

        public void printAPyramid()
        {
            Console.WriteLine("-------Print-a-Pyramid-------");
            Console.WriteLine("How many layers you want:");
            int layer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= layer; i++)
            {
                for (int j = 1; j <= layer - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i- 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();  // start a new line every
            }
            
        }

        public void calBirthDays(int year, int month, int date)
        {
            DateTime bDate = new DateTime(year, month, date);  // to get the brithdate
            DateTime today = DateTime.Today;   // to get today's date
            //(EndDate.Date - StartDate.Date).Days
            int days = (today - bDate).Days;
            int daysToNextAnniversary = 10000 - (days % 10000);
            Console.WriteLine($"This person is {days} days old.");
            Console.WriteLine($"This person will have {daysToNextAnniversary} days to next anninversary");

        }

        public void greets()
        {
            DateTime now = DateTime.Now;
            //Console.WriteLine(now);   // 3/16/2022 10:45:01 PM
            if (now.Hour < 12 && now.Hour > 7)
            {
                Console.WriteLine("Good Morning");
            }
            else if (now.Hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (now.Hour < 21)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }

        }

        public void countingNum()
        {
            int count = 1;
            while (count <= 4)
            {
                for (int i = 0; i <= 24; i++)
                {
                    if (i % count == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                count++;
            }
        }
    }
}
