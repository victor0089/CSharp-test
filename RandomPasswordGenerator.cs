using System;
using System.Text;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Password Generator");
            Console.WriteLine("--------------------------");
            Console.Write("Enter the length of the password: ");
            int length = Convert.ToInt32(Console.ReadLine());

            string password = GenerateRandomPassword(length);
            Console.WriteLine("Generated Password: " + password);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                int randomIndex = rand.Next(0, validChars.Length);
                sb.Append(validChars[randomIndex]);
            }

            return sb.ToString();
        }
    }
}
