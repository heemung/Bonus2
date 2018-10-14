using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus2
{
    class Program
    {
        static DateTime date;
        static DateTime nowDate = DateTime.Now;
        static void Main(string[] args)
        {
            string userYear, userMonth, userDay, textDateFull;
            bool testDate, userContinue = true;

            Console.WriteLine("Enter Your Birthday");
            while (userContinue)
            {
                do
                {
                    Console.Write("What is the year? Example: 1990 -- ");
                    userYear = Console.ReadLine();
                    Console.Write("What is the Month? Example: 01 -- ");
                    userMonth = Console.ReadLine();
                    Console.Write("What is the Day? Example: 05 -- ");
                    userDay = Console.ReadLine();


                    textDateFull = userMonth + "/" + userDay + "/" + userYear;
                    testDate = DateTime.TryParse(textDateFull, out date);


                    if (!testDate)
                        Console.WriteLine("\nPlease Enter Valid Date. Try Again.\n");
                } while (!testDate);

                GetYearsAndDays(date);
                Console.WriteLine("Do you want to run the program again? y/n?");
                userContinue = Console.ReadLine().ToLower() == "y";
            }


        }

        static bool ItsMyBirthday()
        {
            if (date == nowDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void GetYearsAndDays(DateTime dateCopy)
        {
            TimeSpan dateDifference;
            double toYears, toDays;
            Console.WriteLine(dateCopy);
            Console.ReadLine();

            dateDifference = (nowDate - dateCopy);
            Console.WriteLine(dateDifference.Days);
            Console.ReadLine();
            toYears = dateDifference.Days / 365;
            toDays = dateDifference.Days % 365;

            if (ItsMyBirthday() == true)
            {
                Console.WriteLine("Happy Birthday!!!\n" +
                    "You are {0} years old.", toYears);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You are {0} years old and {1} days.", toYears, toDays);
            }
        }
    }
}
