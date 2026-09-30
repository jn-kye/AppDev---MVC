using System.Transactions;

namespace MVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Login");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Your username: " + username);


            Console.ReadLine();
        }
    }
}
