using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Scientific Calculator");

        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Square Root");
            Console.WriteLine("6. Power");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Exiting the calculator...");
                break;
            }

            switch (choice)
            {
                case "1":
                    Addition();
                    break;
                case "2":
                    Subtraction();
                    break;
                case "3":
                    Multiplication();
                    break;
                case "4":
                    Division();
                    break;
                case "5":
                    SquareRoot();
                    break;
                case "6":
                    Power();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void Addition()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }

    static void Subtraction()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 - num2;
        Console.WriteLine("Result: " + result);
    }

    static void Multiplication()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 * num2;
        Console.WriteLine("Result: " + result);
    }

    static void Division()
    {
        Console.Write("Enter the dividend: ");
        double dividend = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        double divisor = Convert.ToDouble(Console.ReadLine());

        if (divisor != 0)
        {
            double result = dividend / divisor;
            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
    }

    static void SquareRoot()
    {
        Console.Write("Enter the number: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num >= 0)
        {
            double result = Math.Sqrt(num);
            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Cannot calculate square root of a negative number.");
        }
    }

    static void Power()
    {
        Console.Write("Enter the base: ");
        double num = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        double result = Math.Pow(num, exponent);
        Console.WriteLine("Result: " + result);
    }
}
