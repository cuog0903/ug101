using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    public class LinearEquationResolver
    {
     
        public static void SolverLinearEquation()
        {
            Console.WriteLine("Linear  Equation Reslover");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants");
            double a, b;
            Console.Write("Enter a: ");
            checkInput(out a);
            Console.Write("Enter b: ");
            checkInput(out b);
            if (a != 0)
            {
                Console.WriteLine($"The solution is: {-b / a}");
            }
            else if (b == 0)
            {
                Console.WriteLine("The solution is all x!");
            }
            else Console.WriteLine("Nod solution!");
        }
        //Hàm kiểm tra hợp lệ của dữ liệu đầu vào 
        public static void checkInput(out double dataOutput)
        {

            while (true)
            {
                string? dataInput = Console.ReadLine();
                if (double.TryParse(dataInput, out dataOutput)) break;//Nếu dữ liệu nhập vào có định dạng đúng thí gán giá trị cho biến và thoát khỏi vòng lặp 
                else Console.Write("Data input was wrong!!!Please enter again: "); //nếu không đúng định dạng thì yêu cầu người dùng nhập lại

            }

        }
    }
}
