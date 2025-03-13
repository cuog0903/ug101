using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    public class DayInMonth
    {
        public enum MonthList
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12,

        }
        public static void CountDaysInMonth()
        {
            int month, year, daysInMonth = 0;
            MonthList monthList;

            Console.Write("Enter year that you want to check: ");
            checkDataInput(out year);
            Console.WriteLine("Which month that you want to count days? ");
            while (true)
            {
                Console.Write("Enter Month: ");
                checkDataInput(out month);
                if (month >= 1 && month <= 12) break;
                else Console.WriteLine("The month entered not correct. Please enter again (the month a number from 1 to 12): ");
            }
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    if (checkLeadYear(year)) daysInMonth = 29;
                    else daysInMonth = 28;
                    break;
                default:
                    daysInMonth = 31;
                    break;
            }
            if(daysInMonth == 29) Console.WriteLine($"The {(MonthList)month} has {daysInMonth} days! Because the year is leap year ");
            else Console.WriteLine($"The {(MonthList)month} has {daysInMonth} days!");


        }
        public static void checkDataInput(out int dataOutput)
        {
            while (true)
            {
                string? dataInput = Console.ReadLine();
                if (int.TryParse(dataInput, out dataOutput)) break;
                else Console.WriteLine("Data input was wrong. Please enter again: ");
            }
        }
        public static bool checkLeadYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else return false;

        }
    }
}
