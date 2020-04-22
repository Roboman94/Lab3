using System;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Decision Validator!");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();


            int cont = 1;
            int cont2 = 1;
            while (cont == 1)
                {   // Entry Validation
                Console.WriteLine("Enter a number between 1 and 100");
                string input = Console.ReadLine();

                int i = 0;
                int validcheck = 1;
                int validcheck2 = 1;
                while (validcheck == 1)
                    {   //Validation Variable
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
                    else
                    { 
                        validcheck = 2; 
                    }
                    if (validcheck == 2 || validcheck2 == 2)
                    {
                        cont = 1;
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
                    cont = 0;
                    cont2 = 1;
                    Console.WriteLine($"{name}, the number you entered {i} is even and less than 25!");
                    Console.WriteLine();
                }
                else if (oddeven == 2 && i >= 26 && i <= 60)
                {
                    cont = 0;
                    cont2 = 1;
                    Console.WriteLine($"{name}, the number you entered {i} is even and more than 26!");
                    Console.WriteLine();
                }
                else if (oddeven == 2 && i >= 60)
                {
                    cont = 0;
                    cont2 = 1;
                    Console.WriteLine($"{name}, the number you entered {i} is more than 60 and an even number!");
                    Console.WriteLine();
                }
                else if (oddeven == 1 && i >= 60)
                {
                    cont = 0;
                    cont2 = 1;
                    Console.WriteLine($"{name}, the number you entered {i} is more than 60 and an odd number!");
                    Console.WriteLine();
                }
                else if (oddeven == 1)
                {
                    cont = 0;
                    cont2 = 1;
                    Console.WriteLine($"{name}, the number you entered {i} is odd");
                    Console.WriteLine();
                }

                
                while (cont2 == 1)
                {
                    //Continue?.. entry
                    Console.WriteLine("Would you like to continue? (y/n) ");
                    string proceed = Console.ReadLine();
                    Console.WriteLine();
                    //Continue variable
                    if (proceed.ToLower().StartsWith("y"))
                    {
                        cont = 1;
                        cont2 = 0;
                    }
                    if (proceed.ToLower().StartsWith("n"))
                    {
                        cont = 0;
                        cont2 = 0;
                        Console.WriteLine("thank you for using the Decision Maker!");
                        Console.WriteLine();
                        break;
                    }
                   
                    if (cont2 == 1)
                    {
                        Console.WriteLine("invalid entry! please try again.");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}





