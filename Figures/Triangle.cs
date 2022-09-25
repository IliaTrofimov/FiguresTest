using System;

namespace Figures
{
    public class Triangle : IFigure
    {
        private double x1, x2, x3, y1, y2, y3;

        public double X1
        {
            get => x1;
            set
            {
                x1 = value;
                if (!CheckSides())
                    throw new ArgumentException($"Cannot create triangle with such verticies (sides {Side12}, {Side23}, {Side31})", "value");
            }
        }

        public double X2
        {
            get => x2;
            set
            {
                x2 = value;
                if (!CheckSides())
                    throw new ArgumentException($"Cannot create triangle with such verticies (sides {Side12}, {Side23}, {Side31})", "value");
            }
        }

        public double X3
        {
            get => x3;
            set
            {
                x3 = value;
                if (!CheckSides())
                    throw new ArgumentException($"Cannot create triangle with such verticies (sides {Side12}, {Side23}, {Side31})", "value");
            }
        }

        public double Y1
        {
            get => y1;
            set
            {
                y1 = value;
                if (!CheckSides())
                    throw new ArgumentException($"Cannot create triangle with such verticies (sides {Side12}, {Side23}, {Side31})", "value");
            }
        }

        public double Y2
        {
            get => y2;
            set
            {
                y2 = value;
                if (!CheckSides())
                    throw new ArgumentException($"Cannot create triangle with such verticies (sides {Side12}, {Side23}, {Side31})", "value");
            }
        }

        public double Y3
        {
            get => y3;
            set
            {
                y3 = value;
                if (!CheckSides())
                    throw new ArgumentException($"Cannot create triangle with such verticies (sides {Side12}, {Side23}, {Side31})", "value");
            }
        }


        public double Side12 => Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        public double Side23 => Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
        public double Side31 => Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));


        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            if (!CheckSides())
                throw new ArgumentException($"Cannot create triangle with such verticies (sides {Side12}, {Side23}, {Side31})");
        }

        private bool CheckSides()
        {
            double s1 = Side12;
            double s2 = Side23;
            double s3 = Side31;

            return s1 + s2 > s3 && s2 + s3 > s1 && s1 + s3 > s2;
        }


        /// <summary>
        /// Calculates triangles's with Heron's formula as sqrt(p*(p - a)*(p - b)*(p - c))
        /// </summary>
        public double GetArea()
        {
            double s1 = Side12;
            double s2 = Side23;
            double s3 = Side31;
            double p = (s1 + s2 + s3) / 2;
            return Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
        }

        public override string ToString()
        {
            return $"Triangle(S12={Side12}, S23={Side23}, S31={Side31})";
        }
    }
}
