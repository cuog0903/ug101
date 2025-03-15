using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConvertNumbersToWords
{
    internal class Program
    {
        public enum NumbersUnit
        {
            None = 0,
            One = 1,
            Two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9,

        }
        public enum NumbersFromTenToNineTeen
        {
            ten = 0,
            eleven = 1,
            twelve = 2,
            thirteen = 3,
            fourteen = 4,
            fifteen = 5,
            sixteen = 6,
            seventeen = 7,
            eighteen = 8,
            nineteen = 9,
        }
        public enum NumberDozens
        {
            twenty = 2,
            thirty = 3,
            forty = 4,
            fifty = 5,
            sixty = 6,
            seventy = 7,
            eighty = 8,
            ninety = 9
        }
        static void Main(string[] args)
        {
            ProgramReadANumber();
        }
        public static void ProgramReadANumber()
        {
            Console.WriteLine("Program read a number!!!");
            Console.WriteLine("Enter your choice following ");
            while (true)
            {
                int number, choice;

                Console.WriteLine("1. Read a number!!!");
                Console.WriteLine("0. Quit");
                Console.Write("Your choice is: ");
                CheckDataInput(out choice);

                if (choice != 0 && choice != 1)
                {
                    Console.WriteLine("Your choice not conrrect, please choice again!!");
                }
                else
                {
                    if (choice == 1)
                    {
                        Console.Write("Enter number you want to read: ");
                        CheckDataInput(out number);
                        ConvertNumbers(number);
                    }
                    if (choice == 0)
                    {
                        Console.WriteLine("Thanks for using program. See you later!!!");
                        return;
                    }
                }

            }
        }
        public static void ConvertNumbers(int number)
        {
            int count = 0;
            int[] numbers = new int[3];

            while (number > 0)
            {
                numbers[count] = number % 10;
                number /= 10;
                count++;
            }
            switch (--count)
            {
                case 0:
                    Console.WriteLine((NumbersUnit)numbers[count]);
                    break;
                case 1:
                    if (numbers[1] == 1)
                    {
                        if (numbers[0] == 0) Console.WriteLine((NumbersFromTenToNineTeen)0);
                        else Console.WriteLine((NumbersFromTenToNineTeen)numbers[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{(NumberDozens)numbers[1]} {(NumbersUnit)numbers[0]}");
                    }
                    break;
                case 2:
                    if (numbers[1] == 0)
                    {
                        if (numbers[0] == 0)
                        {
                            Console.WriteLine($"{(NumbersUnit)numbers[2]} hundred");
                        }
                        else
                        {
                            Console.WriteLine($"{(NumbersUnit)numbers[2]} hundred and {(NumbersUnit)numbers[0]}");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{(NumbersUnit)numbers[2]} hundred and {(NumberDozens)numbers[1]} {(NumbersUnit)numbers[0]}");
                    }

                    break;
            }

        }
        public static void CheckDataInput(out int dataOutput)
        {
            while (true)
            {
                string? dataInput = Console.ReadLine();
                string nonNullData = dataInput ?? "";
                if (int.TryParse(nonNullData, out dataOutput)) break;
                else Console.WriteLine("Data input not correct. Please enter again: ");

            }

        }
    }
}
