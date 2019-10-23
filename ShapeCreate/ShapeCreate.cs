using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;


namespace ShapeCreate
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message)
        {

        }

    }
    
    public class Create
    {
        static string[] colours = { "red", "green", "blue", "black", "white" };
        static void Main(string[] args)
        {


            Console.WriteLine("To create a Square press (1)");
            Console.WriteLine("To create a Rectangle press (2)");
            Console.WriteLine("To create a Right Angled Triangle press (3)");
            Console.WriteLine("To create an Equilateral Triangle press (4)");
            Console.WriteLine("To create a Circle press (5)");
            Console.Write("Enter selection: ");
            var choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {

                List<Square> s = new List<Square>();

                try
                {

                    Console.Write("Please enter the Side Length of your square: ");

                    Console.WriteLine("Enter colour...");
                    var c1 = Console.ReadLine();
                    if(Array.IndexOf(colours, c1) == -1)
                    {
                        throw new InvalidInputException("Invalid colour");
                        
                    }


                    Console.WriteLine("Enter side length...");
                    var squareSide1 = int.Parse(Console.ReadLine());

                    if (squareSide1 < 1)
                    {
                        throw new InvalidInputException("Invalid input, numbers must not be negative");
                    }

                    s.Add(new Square(c1, squareSide1));
                }
                catch (InvalidInputException message)
                {
                    Console.WriteLine(message);
                }


                foreach (Square i in s)
                    Console.WriteLine("Square: " + i.ToString());

            }


            else if (choice == 2)
            {

                List<Rectangle> r = new List<Rectangle>();

                try
                {

                    Console.WriteLine("Enter colour...");
                    var c2 = Console.ReadLine();
                    if (Array.IndexOf(colours, c2) == -1)
                    {
                        throw new InvalidInputException("Invalid colour");

                    }

                    Console.WriteLine("Enter first side length...");
                    var rectSide1 = int.Parse(Console.ReadLine());
                    if (rectSide1 < 1)
                    {
                        throw new InvalidInputException("Invalid input, numbers must not be negative");
                    }

                    Console.WriteLine("Enter second side length...");
                    var rectSide2 = int.Parse(Console.ReadLine());

                    if (rectSide2 < 1)
                    {
                        throw new InvalidInputException("Invalid input, numbers must not be negative");
                    }
                    r.Add(new Rectangle(c2, rectSide1, rectSide2));

                }

                catch (InvalidInputException message)
                {
                    Console.WriteLine(message);
                }


                foreach (Rectangle i in r)
                    Console.WriteLine("Rectangle: " + i.ToString());

            }
            else
            {
                Console.WriteLine("invalid option");
            }


            if (choice == 3)
            {

                List<RightAngle> rAngle = new List<RightAngle>();

                try
                {

                    Console.WriteLine("Enter colour...");
                    var c3 = Console.ReadLine();
                    if (Array.IndexOf(colours, c3) == -1)
                    {
                        throw new InvalidInputException("Invalid colour");

                    }

                    Console.WriteLine("Enter first side length...");
                    var rAngleSide1 = int.Parse(Console.ReadLine());
                    if (rAngleSide1 < 1)
                    {
                        throw new InvalidInputException("Invalid input, numbers must not be negative");
                    }

                    Console.WriteLine("Enter second side length...");
                    var rAngleSide2 = int.Parse(Console.ReadLine());

                    if (rAngleSide2 < 1)
                    {
                        throw new InvalidInputException("Invalid input, numbers must not be negative");
                    }
                    rAngle.Add(new RightAngle(c3, rAngleSide1, rAngleSide2, rAngleSide3));

                }

                catch (InvalidInputException message)
                {
                    Console.WriteLine(message);
                }


                foreach (RightAngle i in rAngle)
                    Console.WriteLine("RightAngledTriangle: " + i.ToString());

            }
            else
            {
                Console.WriteLine("invalid option");





            }



                Console.ReadKey();

            }
        }
    }

