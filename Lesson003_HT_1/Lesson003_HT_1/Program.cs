using System;

namespace Lesson003_HT_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string Milk;
            string Chiken;
            string Potato;
            string Water;
            string Soda;
            string Table;
            string Onion;
            string Butter;
            string Fish;
            string Meat;
            Console.WriteLine("Enter word you want to translate:");
            string enter = Console.ReadLine();
            switch (enter)
            {
                case "Milk":
                    {
                        Console.WriteLine("Молоко");
                        break;
                    }
                case "Chiken":
                    {
                        Console.WriteLine("Курка");
                        break;
                    }
                case "Potato":
                    {
                        Console.WriteLine("Картопля");
                        break;
                    }
                case "Water":
                    {
                        Console.WriteLine("Вода");
                        break;
                    }
                case "Soda":
                    {
                        Console.WriteLine("Газована вода");
                        break;
                    }
                case "Table":
                    {
                        Console.WriteLine("Стіл");
                        break;
                    }
                case "Onion":
                    {
                        Console.WriteLine("Цибуля");
                        break;
                    }
                case "Butter":
                    {
                        Console.WriteLine("Масло");
                        break;
                    }
                case "Fish":
                    {
                        Console.WriteLine("Риба");
                        break;
                    }
                case "Meat":
                    {
                        Console.WriteLine("М'ясо");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("This word is not available in the dictionary!");
                        break;
                    }
                    

                    
            }
        }
    }
}
