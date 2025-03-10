using System.Globalization;

namespace ConverterCurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rateCurency = 23_000; //Tỷ giá
            Console.Write("Enter USD: ");
            float yourMoneyInUSD = float.Parse(Console.ReadLine()); //Nhập vào số tiền USD muốn quy đổi 
            CultureInfo culture = new CultureInfo("vi-VN"); //Hiển thị tiền tệ theo đồng Việt Nam
            Console.WriteLine($"Your Monney in VND is: {(yourMoneyInUSD * rateCurency).ToString("C", culture)}");

        }
    }
}
