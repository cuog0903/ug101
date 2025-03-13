using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    public class BMI
    {
 
        public static void CalculatedBMI()
        {
            Console.WriteLine("The program calculate BMI");
            //Enter data input
            Console.Write("Please enter your height: ");
            checkInput(out double height);
            Console.Write("Please enter your weight: ");
            checkInput(out double weight);
            //Caculate BMI
            double bmi = Math.Round(weight / Math.Pow(height, 2), 1);
            Console.WriteLine("BMI: " + bmi);
            if(bmi < 18.5) Console.WriteLine("Underweight");
            else if(bmi < 25.0) Console.WriteLine("Normal");
            else if(bmi < 30.0) Console.WriteLine("Overweight");
            else Console.WriteLine("Obese");
            

        }
        public static void checkInput(out double dataOutput)
        {
            while (true)
            {
                string? dataInput = Console.ReadLine();
                if (double.TryParse(dataInput, out dataOutput)) break;
                else Console.Write("Data inpit was wrong. Please input again: ");
            }
        }
    }
}
