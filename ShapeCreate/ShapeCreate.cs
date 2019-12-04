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

            //square
            if (choice == 1)
            {

                List<Square> s = new List<Square>();

                try
                {

         

                    Console.WriteLine("Enter colour...");
                    string c1 = Console.ReadLine();
                    if (Array.IndexOf(colours, c1) == -1)
                    {
                        throw new InvalidInputException("Invalid colour");

                    }                                  
                    Console.WriteLine("Enter side length...");
                    double squareSide1 = Convert.ToDouble(Console.ReadLine());


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


            //rectangle
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
            



            //right angled
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
                    rAngle.Add(new RightAngle(c3, rAngleSide1, rAngleSide2));

                }

                catch (InvalidInputException message)
                {
                    Console.WriteLine(message);
                }


                foreach (RightAngle i in rAngle)
                    Console.WriteLine("RightAngledTriangle: " + i.ToString());
            }


            //equilateral
            if (choice == 4)
            {

                List<Equilateral> rAngle = new List<Equilateral>();

                try
                {

                    Console.WriteLine("Enter colour...");
                    var c3 = Console.ReadLine();
                    if (Array.IndexOf(colours, c3) == -1)
                    {
                        throw new InvalidInputException("Invalid colour");

                    }

                    Console.WriteLine("Enter first side length...");
                    var EquliateralSide1 = int.Parse(Console.ReadLine());
                    if (EquliateralSide1 < 1)
                    {
                        throw new InvalidInputException("Invalid input, numbers must not be negative");
                    }

                    Console.WriteLine("Enter second side length...");
                    var rAngleSide2 = int.Parse(Console.ReadLine());

                    if (rAngleSide2 < 1)
                    {
                        throw new InvalidInputException("Invalid input, numbers must not be negative");
                    }
                    rAngle.Add(new Equilateral(c3, EquliateralSide1));

                }

                catch (InvalidInputException message)
                {
                    Console.WriteLine(message);
                }


                foreach (Equilateral i in rAngle)
                    Console.WriteLine("Equilateral Triangle: " + i.ToString());
            }


            //circle
            if (choice == 5)
            {

                List<Circle> s = new List<Circle>();

                try
                {



                    Console.WriteLine("Enter colour...");
                    string c1 = Console.ReadLine();
                    if (Array.IndexOf(colours, c1) == -1)
                    {
                        throw new InvalidInputException("Invalid colour");

                    }
                    Console.WriteLine("Enter Radius...");
                    double Radius = Convert.ToDouble(Console.ReadLine());


                    if (Radius < 1)
                    {
                        throw new InvalidInputException("Invalid input, numbers must not be negative");
                    }

                    s.Add(new Circle(c1, Radius));
                }
                catch (InvalidInputException message)
                {
                    Console.WriteLine(message);
                }


                foreach (Circle i in s)
                    Console.WriteLine("Circle: " + i.ToString());

            }
















            Console.ReadKey();

            }
        }
    }

