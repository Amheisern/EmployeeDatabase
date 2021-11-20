using System;
namespace EmployeeDatabase
{
    class Program
    {
        static void DisplayGreeting()
        {

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    Welcome to Our Employee Database    ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }
        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            int inputAsInteger;
            var isThisGoodInput = int.TryParse(userInput, out inputAsInteger);
            if (isThisGoodInput)
            {
                return inputAsInteger;
            }
            else
            {
                Console.Write("that isn't a number");
                return 0;
            }
            // var intValue = int.Parse(userInput);
            return intValue;
        }

        static void Main(string[] args)
        {
            DisplayGreeting();

            var name = PromptForString("What is your name");
            //var name = Console.ReadLine();

            var department = PromptForInteger("What is your department number? ");
            // Console.Write("What is your department number? ");
            // int department = int.Parse(Console.ReadLine());

            var salary = PromptForInteger("What is your salary (in dollars)? ");
            // Console.Write("What is your yearly salary (in dollars)? ");
            // int salary = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {name} you make {salary / 12} dollars per month.");
        }


    }
}