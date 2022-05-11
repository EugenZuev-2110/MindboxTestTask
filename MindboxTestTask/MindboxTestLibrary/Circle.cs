using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestLibrary
{
    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * radius * radius;
        }
    }
}
