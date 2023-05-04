using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string? str = Console.ReadLine();
            Console.WriteLine(Anagram.Reverse(str));
        }
    }
}