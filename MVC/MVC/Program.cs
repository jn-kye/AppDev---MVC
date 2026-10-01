using System.Transactions;

namespace MVC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Version 2.0\n");

            bool isCorrect = true;

            do
            {
                Console.WriteLine("User Information");
                Console.Write("Enter your First name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter your Last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nYour name is: " + firstName + " " + lastName);
                Console.WriteLine("Your age is: " + age);

                Console.Write("Is the information correct?: ");
                string verify = Console.ReadLine();

                if (verify == "Yes" || verify == "yes") 
                    isCorrect = false;

                else
                    Console.WriteLine("Please enter your correct information.\n");

            } while (isCorrect);

            Console.WriteLine("\nInformation Saved!");

            Console.ReadLine();
        }
    }
}
