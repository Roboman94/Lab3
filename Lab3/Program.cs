using System;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Numeric Validator!");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            int cont = 1;

            while (cont == 1)
            {
                // Entry Validation
                Console.WriteLine("Enter a number between 1 and 100");
                string input = Console.ReadLine();
                int i = 0;
                int validcheck = 1;
                int validcheck2 = 1;

                while (validcheck == 1)
                {
                    if (input.All(char.IsNumber))
                    {
                        validcheck = 0;
                    }
                    else
                    {
                        validcheck = 2;
                    }

                    if (validcheck != 2)
                    {
                        i = int.Parse(input);
    
                    }
                    if (i >= 1 && i <= 100)
                    {
                        validcheck2 = 0;
                    }

                    if (validcheck == 2 || validcheck2 == 2)
                        {
                        validcheck = 1;
                        validcheck2 = 1;
                        Console.WriteLine("invalid entry, please try again");
                        Console.WriteLine("Enter a number between 1 and 100");
                        input = Console.ReadLine();
                    }
                    
                }

                //OddEven Variable
                int oddeven = 0;
                if (i % 2 == 0)
                { oddeven = 2; }
                else { oddeven = 1; }
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
                else if (oddeven == 1)
                {
                    Console.WriteLine($"{name}, the number you entered {i} is odd");
                }

                int cont2 = 1;
                while (cont2 == 1)
                {
                    //Continue?.. entry
                    Console.WriteLine("Would you like to continue? (y/n) ");
                    string proceed = Console.ReadLine();
                    Console.WriteLine();

                    //Continue variable
                    if (proceed.ToLower() == "y")
                    { 
                        cont2 = 2; 
                    }
                    if (proceed.ToLower() == "n")
                    {
                        cont = 0;
                        cont2 = 1;
                        break;
                    }
                    if (proceed.ToLower() == "no")
                    {
                        cont = 0;
                        cont2 = 1;
                        break;
                    }
                    if (proceed.ToLower() == "yes")
                    { 
                        cont2 = 2; 
                    }
                    if (cont2 == 1)
                    {
                        Console.WriteLine("invalid entry! please try again.");
                        cont2 = 1;
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}




