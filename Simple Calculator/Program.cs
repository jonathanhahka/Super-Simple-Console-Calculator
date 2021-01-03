using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            string oper8;


            {
                Console.Write("Enter an operator: ");
                oper8 = Console.ReadLine();
            }
            {
                if (oper8 == "+")
                {
                    Console.WriteLine("Nice, you know what an operator is, genius!");
                }
                else if (oper8 == "-")
                {
                    Console.WriteLine("Nice, you know what an operator is, genius!");
                }
                else if (oper8 == "*")
                {
                    Console.WriteLine("Nice, you know what an operator is, genius!");
                }
                else if (oper8 == "/")
                {
                    Console.WriteLine("Nice, you know what an operator is, genius!");
                }

                //while (!oper8.Equals(string.Empty));            



                {

                    Console.Write("Enter a number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    {
                        Console.Write("Enter a second number: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    {
                        Console.WriteLine("The answer to " + (num1 + " " + oper8 + " " + num2 + " is: "));

                    }
                    {
                        if (oper8 == "+")

                            Console.WriteLine(num1 + num2);
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
                            Console.WriteLine("You screwed up.");
                    }

                    
                    Console.ReadKey();
                }

            }
        }
    }
}
