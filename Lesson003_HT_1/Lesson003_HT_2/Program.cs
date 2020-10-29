using System;

namespace Lesson003_HT_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double operand1 = 2;
            double operand2 = 8;
            Console.WriteLine("Enter sign:");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    {
                        double res = operand1 + operand2;
                        Console.WriteLine($"Result --> {res}");
                        break;
                    }
                case "-":
                    {
                        double res = operand1 - operand2;
                        Console.WriteLine($"Result --> {res}");
                        break;
                    }
                case "*":
                    {
                        double res = operand1 * operand2;
                        Console.WriteLine($"Result --> {res}");
                        break;
                    }
                case "/":
                    {
                        if(operand2 == 0)
                        {
                            Console.WriteLine("Cant divide ZERO");
                        }
                        else
                        {
                            double res = operand1 / operand2;
                            Console.WriteLine($"Result --> {res}");

                        }
                       
                        break;
                    }
                case "%":
                    {
                        double res = operand1 % operand2;
                        Console.WriteLine($"Result --> {res}");
                        break;
                    }
            }
        }
    }
}
