using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    public class LeapYear
    {

        public static void checkLeapYear()
        {
            Console.WriteLine("Program check Leap year");
            Console.Write("Enter year: ");
            checkInput(out int year);
            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }else Console.WriteLine("{0} is NOT a leap year", year);

        }
        public static void checkInput(out int dataOutput)
        {
            while (true)
            {
                string? dataInput = Console.ReadLine();
                if (int.TryParse(dataInput, out dataOutput)) break;
                else Console.Write("Data input was wrong. Please input again: ");
            }

        }
    }
}
