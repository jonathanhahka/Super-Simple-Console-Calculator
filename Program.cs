using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string oper8;
            double num1;
            double num2;
            bool valid = true;
            //bool success = true;


            // Asks for user input of an operator until correct.

            do
            {
                Console.Write("Enter an operator (+,-,*, or /): ");
                oper8 = Console.ReadLine();
                if (oper8 == "+")
                    valid = true;
                else if (oper8 == "-")
                    valid = true;
                else if (oper8 == "*")
                    valid = true;
                else if (oper8 == "/")
                    valid = true;
                else
                    valid = false;

            }
            while (!valid);


                if (oper8 == "+")
                    
                {
                    Console.WriteLine("Nice, you entered +.");
                    valid = true;
                }
                else if (oper8 == "-")
                {
                    Console.WriteLine("Nice, you entered -.");
                    valid = true;
                }

                else if (oper8 == "*")
                {
                    Console.WriteLine("Nice, you entered *.");
                    valid = true;
                }
                else if (oper8 == "/")
                {
                    Console.WriteLine("Nice, you entered /."); 
                
                }
                Console.WriteLine("Enter a number: ");            
                string number1 = (Console.ReadLine());
                
                if (double.TryParse(number1, out num1))
                {
                
                Console.Write("Enter a second number: ");
                string number2 = (Console.ReadLine());
                

                if (double.TryParse(number2, out num2))
                {                
                    Console.WriteLine("The answer to " + (num1 + " " + oper8 + " " + num2 + " is:"));                
                }

                if (oper8 == "+")
                {
                    Console.WriteLine(num1 + num2);
                }
                else if
                    (oper8 == "-")
                    Console.WriteLine(num1 - num2);
                else if
                    (oper8 == "*")
                    Console.WriteLine(num1 * num2);
                else if
                    (oper8 == "/")
                    Console.WriteLine(num1 / num2);
                else
                    Console.WriteLine("you screwed up.");
                }

            {
                Console.ReadKey();
            }
                        
        }
    }

}