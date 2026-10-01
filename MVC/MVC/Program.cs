using System.Transactions;

namespace MVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;

            Console.WriteLine("Application Login");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Your username: " + username);

            do
            {
                Console.Write("Enter your password to continue: ");
                password = Console.ReadLine();
            }while (string.IsNullOrEmpty(password));

            Console.WriteLine("Welcome to the Program!");

            Console.ReadLine();
        }
    }
}
