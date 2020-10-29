using System;

namespace Lesson003_HT_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter n, from 0 by 100:");
            string n = Console.ReadLine();
            int number = int.Parse(n);
            if (number < 0 || number > 100)
            {
                Console.WriteLine("Wrong number, try again");
            }
            else
            {
                if(number>=0 && number < 14)
                {
                    Console.WriteLine("[0 - 14]");
                }
                if (number >= 15 && number < 35)
                {
                    Console.WriteLine("[15 - 35]");
                }
                if (number >= 36 && number < 50)
                {
                    Console.WriteLine("[36 - 50]");
                }
                if (number >= 51 && number < 100)
                {
                    Console.WriteLine("[51 - 100]");
                }
            }
            
        }
    }
}
