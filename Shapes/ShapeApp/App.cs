using System;
using ShapeLib;

namespace ShapeApp
{
    class App
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();

                Console.WriteLine("Make a Shape!");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Equilateral Triangle");
                Console.WriteLine("4. Right Angle Triangle");
                Console.WriteLine("5. Circle");
                Console.WriteLine("e. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("You are making a square");
                            Console.WriteLine("What colour is it?");
                            string colour = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"You are making a {colour} square");
                            Console.WriteLine("What is its side length?");
                            double side = GetNum();
                            Square square = new Square(colour, side);
                            Console.Clear();
                            Console.WriteLine($"You created a {colour} square with side length: {side}, an area of {square.GetArea()} and a perimeter of {square.GetPerimeter()}");
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("You are making a rectangle");
                            Console.WriteLine("What colour is it?");
                            string colour = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"You are making a {colour} rectangle");
                            Console.WriteLine("How wide is it?");
                            double width = GetNum();
                            Console.Clear();
                            Console.WriteLine($"You are making a {colour} rectangle with width: {width}");
                            Console.WriteLine("How tall is it?");
                            double height = GetNum();
                            Rectangle rectangle = new Rectangle(colour, width, height);
                            Console.Clear();
                            Console.WriteLine($"You created a {colour} rectangle with width: {width}, height: {height}, an area of {rectangle.GetArea()} and a perimeter of {rectangle.GetPerimeter()}");
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("You are making an equilateral triangle");
                            Console.WriteLine("What colour is it?");
                            string colour = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"You are making a {colour} equilateral triangle");
                            Console.WriteLine("What is its side length?");
                            double side = GetNum();
                            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(colour, side);
                            Console.Clear();
                            Console.WriteLine($"You created a {colour} equilateral triangle with side length: {side}, an area of {equilateralTriangle.GetArea()} and a perimeter of {equilateralTriangle.GetPerimeter()}");
                            Console.ReadKey();
                        }
                        break;
                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("You are making a right angle triangle");
                            Console.WriteLine("What colour is it?");
                            string colour = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"You are making a {colour} right angle triangle");
                            Console.WriteLine("How wide is it?");
                            double width = GetNum();
                            Console.Clear();
                            Console.WriteLine($"You are making a {colour} right angle triangle with base: {width}");
                            Console.WriteLine("How tall is it?");
                            double height = GetNum();
                            RightAngleTriangle rightAngleTriangle = new RightAngleTriangle(colour, width, height);
                            Console.Clear();
                            Console.WriteLine($"You created a {colour} right angle triangle with base: {width}, height: {height}, an area of {rightAngleTriangle.GetArea()} and a perimeter of {rightAngleTriangle.GetPerimeter()}");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("You are making a circle");
                            Console.WriteLine("What colour is it?");
                            string colour = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"You are making a {colour} circle");
                            Console.WriteLine("What is its side length?");
                            double radius = GetNum();
                            Circle circle = new Circle(colour, radius);
                            Console.Clear();
                            Console.WriteLine($"You created a {colour} circle with side length: {radius}, an area of {circle.GetArea()} and a perimeter of {circle.GetPerimeter()}");
                            Console.ReadKey();
                        }
                        break;
                    case "e":
                        {
                            running = false;
                        }
                        break;
                    default:
                        continue;
                }
            }
        }

        public static double GetNum()
        {
            double num;

            while (true)
            {
                try
                {
                    num = float.Parse(Console.ReadLine());

                    if (num < 1)
                    {
                        throw new LessThanOneException();
                    }

                    if (num != (int)num)
                    {
                        throw new DecimalInputException();
                    }
                }
                catch
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    continue;
                }
                break;
            }

            return num;
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
