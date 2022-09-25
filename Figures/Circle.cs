using System;

namespace Figures
{
    public class Circle: IFigure
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                if (value < 0) 
                    throw new ArgumentOutOfRangeException("value", "Circle radius must be non-negative value");
                _radius = value;
            }
        }
        public double X { get; set; }
        public double Y { get; set; }


        public Circle(double radius, double x = 0, double y = 0)
        {
            Radius = radius;
            X = x;
            Y = y;
        }


        /// <summary>
        /// Calculates circle's area as pi*r^2
        /// </summary>
        public double GetArea() => Math.PI * Radius * Radius;

        public override string ToString()
        {
            return $"Circle({X}, {Y}, r={Radius})";
        }
    }
}
