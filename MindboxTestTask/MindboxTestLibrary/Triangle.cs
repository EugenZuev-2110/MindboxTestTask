using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestLibrary
{
    public class Triangle : IFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }

        public double GetSquare()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p*(p - sideA)*(p - sideB)*(p - sideC));
        }

        public bool IsRightTriangle()
        {
            var sortedSides = SortedSides();

            return IsRightTriangleOperate(sortedSides);
        }

        private bool IsRightTriangleOperate(double [] arr)
        {
            if((Math.Pow(arr[0], 2) + (Math.Pow(arr[1], 2))) == Math.Pow(arr[2], 2))
                return true;
            return false;
        }

        private double[] SortedSides()
        {
            double shortSide;
            double midSide;
            double longSide;

            double[] sides = new double[] { sideA, sideB, sideC };

            longSide = sides.Max();
            shortSide = sides.Min();
            midSide = sides.Where(n => n != longSide && n != shortSide).First();

            sides = new double[] { shortSide, midSide, longSide };
            return sides;
        }
    }
}
