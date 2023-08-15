using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be positive values.");
            }

            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : Shape
    {
        private double side1, side2, side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("All sides must be positive values.");
            }

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException("Invalid side lengths. The sum of any two sides must be greater than the length of the third side.");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;

        }

        public override double CalculateArea()
        {


            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);

            double smallestSidesSquareSum = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
            double largestSideSquare = Math.Pow(sides[2], 2);

            bool isRightTriangle = Math.Abs(smallestSidesSquareSum - largestSideSquare) < 0.0001;

            if (isRightTriangle)
            {
                Console.WriteLine("This triangle is a right triangle.");
            }
            else
            {
                Console.WriteLine("This triangle is not a right triangle.");
            }

            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
    }


}
