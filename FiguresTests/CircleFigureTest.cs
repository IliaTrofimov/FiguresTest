using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class CircleFigureTest
    {
        public int Seed = 71;
        public double Epsilon = 1e-10;

        [TestMethod]
        public void AreaTest()
        {
            double k = new Random(Seed).NextDouble() + 1;
            double r = Math.Sqrt(k / Math.PI);
            Circle c = new Circle(r);
            Assert.AreEqual(k, c.GetArea(), Epsilon, $"\n{c} calculated area is wrong\n=> Circle.GetArea() formula is incorrect");
        }

        [TestMethod]
        public void CenterInvariantAreaTest()
        {
            double k = new Random(Seed).NextDouble() + 1;
            double r = Math.Sqrt(k / Math.PI);
            Circle c1 = new Circle(r);
            Circle c2 = new Circle(r, 2, 5);
            Assert.AreEqual(c1.GetArea(), c2.GetArea(), Epsilon, $"\n{c1} and {c2} calculated areas must be equal\n=> Circle.GetArea() formula is incorrect");
        }
    }
}
