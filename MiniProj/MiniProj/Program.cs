using System;

namespace MiniProj
{
    class Program
    {
        static void Main(string[] args)
        {
            App ru = new App();
            ru.MiniCalc();
        }
    }
    class App
    {
        public void MiniCalc()
        {
            Console.WriteLine("Select a function.");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int x;
            x = int.Parse(Console.ReadLine());
            if (x != 1 || x != 2 || x != 3 || x != 4)
            {
                while (4 < x || x < 1)
                {
                    Console.WriteLine("Enter a selection between 1 and 4");
                    x = int.Parse(Console.ReadLine());
                }

            }

            switch (x)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    break;
            }
        }

        void Addition()
        {
            Console.Clear();
            Console.WriteLine("Enter two numbers to calculate their sum:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {1} and {2} is {x + y}", x, y);
        }

        void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Enter two numbers to calculate their difference:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"The difference of {1} and {2} is {x - y}", x, y);
        }

        void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Enter two numbers to calculate their product:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"The product of {1} and {2} is {x * y}", x, y);
        }

        void Division()
        {
            Console.Clear();
            Console.WriteLine("Enter two numbers to calculate their quotient:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"The quotient of {1} and {2} is {x / y}", x, y);
        }
    }

}
