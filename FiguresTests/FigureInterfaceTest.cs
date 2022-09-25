using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FiguresTests
{
    [TestClass]
    public class FigureInterfaceTest
    {
        public int Seed = 71;
        public double Epsilon = 1e-10;

        [TestMethod]
        public void RandomFigures()
        {
            int n = 100;
            List<double> areas = new List<double>(n);
            List<IFigure> figures = new List<IFigure>(n);
            Random rnd = new Random(Seed);

            for (int i = 0; i < n; i++)
            {
                if (rnd.NextDouble() > 0.5)
                {
                    double _base = rnd.NextDouble();
                    double h = rnd.NextDouble() + 1;
                    double c = rnd.NextDouble() * 2;
                    Triangle t = new Triangle(0, 0, _base, 0, c, h);
                    figures.Add(t);
                    areas.Add(_base * h / 2);
                }
                else
                {
                    double r = rnd.NextDouble() + 1;
                    figures.Add(new Circle(r, rnd.NextDouble(), rnd.NextDouble()));
                    areas.Add(Math.PI * r * r);
                }
            }

            for (int i = 0; i < n; i++)
            {
                try
                {
                    Assert.AreEqual(areas[i], figures[i].GetArea(), Epsilon, $"\n{figures[i]} had wrong area");
                }
                catch (Exception ex)
                {
                    Assert.Fail($"\nCannot convert figure type or execute IFigure.GetArea():\n{ex}");
                }
            }
        }
    }
}
