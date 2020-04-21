using System;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Digit Validator!");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            int validcheck = 1;
            
            // Entry Validation
            Console.WriteLine("Enter a number between 1 and 100");
            string input = Console.ReadLine();



            int i = 0;

            while (validcheck == 1)
            {

                if (input.All(char.IsNumber)){
                    validcheck = 0;
                }
                else
                {
                    
                    validcheck = 2;
                }

                if (validcheck != 2)
                {
                    i = int.Parse(input);

                    if (input.All(char.IsDigit))
                    {
                        validcheck = 0;
                    }
                    if (i >= 1 && i <= 100)
                    {
                        validcheck = 0;
                    }
                }
                else
                {
                    Console.WriteLine("invalid entry, please try again");
                    Console.WriteLine("Enter a number between 1 and 100");
                    input = Console.ReadLine();
                    i = int.Parse(input);
                }

           //OddEven Results
                int oddeven = 0;
                if (i % 2 == 0)
                {
                    oddeven = 2;

                }
                else
                {
                    oddeven = 1;
                    Console.WriteLine($"{name}, the number you entered {i} is odd");
                }

                if (oddeven == 2 && i >= 2 && i <= 25)
                {
                    Console.WriteLine($"{name}, the number you entered {i} is even and less than 25!");
                }

                if (oddeven == 2 && i >= 26 && i <= 60)
                {
                    Console.WriteLine($"{name}, the number you entered {i} is even and more than 26!");
                }
                if (oddeven == 2 && i >= 60)
                {
                    Console.WriteLine($"{name}, the number you entered {i} is more than 60 and an even number!");
                }
                if (oddeven == 1 && i >= 60)
                {
                    Console.WriteLine($"{name}, the number you entered {i} is more than 60 and an odd number!");
                }

            //Continue?.. entry
                Console.WriteLine("Would you like to continue? (y/n) ");
                string proceed = Console.ReadLine();
                Console.WriteLine();

            //Continue variable
                if (proceed.ToLower() == "y")
                {
                    Console.WriteLine("Enter a number between 1 and 100");
                     input = Console.ReadLine();
                     i = int.Parse(input);
                    validcheck = 1;

                }
                else
                {
                    if (proceed.ToLower() == "yes")
                    {
                        proceed = "y";
                        Console.WriteLine("Enter a number between 1 and 100");
                        input = Console.ReadLine();
                        i = int.Parse(input);
                        validcheck = 1;
                    }

                    if (proceed.ToLower() == "n")
                    {
                        break;
                    }

                    if (proceed.ToLower() == "no")
                    {
                        break;

                    }
                    else
                    {
                        Console.WriteLine("invalid entry! please try again.");
                        Console.WriteLine("Would you like to continue?(y/n)");
                        proceed = Console.ReadLine();
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}


