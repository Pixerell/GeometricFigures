using NUnit.Framework;
using GeometryLibrary;

namespace GeometryCalcTests
{
    public class Tests
    {
        [Test]
        public void CircleArea_CalculateArea()
        {
            double radius = 5.0;
            Circle circle = new Circle(radius);

            // Подсчёт через ожидаемую формулу
            double expectedArea = Math.PI * Math.Pow(radius, 2); 
            double actualArea = circle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void TriangleArea_CalculateArea()
        {
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Подсчёт через ожидаемую формулу
            double s = (side1 + side2 + side3) / 2;
            double expectedArea = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            double actualArea = triangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }


        [Test]
        public void InvalidCircleRadius_ThrowsArgumentException()
        {
            double radius = -2.0;

            Assert.That(() => new Circle(radius), Throws.InstanceOf<ArgumentException>());
        }

        [Test]
        public void InvalidTriangleSides_ThrowsArgumentException()
        {
            double side1 = 1.0;
            double side2 = 2.0;
            double side3 = 10.0;

            Assert.That(() => new Triangle(side1, side2, side3), Throws.InstanceOf<ArgumentException>());
        }

    }
}
