namespace ShowSayHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string inputName = Console.ReadLine();
            Console.WriteLine($"Hello: {inputName}");
        }
    }
}
