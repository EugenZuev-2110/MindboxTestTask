using MindboxTestLibrary;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace FigureTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CircleTest()
        {
            double radius = 2;
            double expected = 12.566370614359172;
            //double expected = 5;

            IFigure circle = new Circle(radius);
            double actual = circle.GetSquare();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            IFigure triangle = new Triangle(a, b, c);
            double actual = triangle.GetSquare();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsRightTriangleTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            Triangle triangle = new Triangle(a, b, c);
            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual);
        }
    }
}