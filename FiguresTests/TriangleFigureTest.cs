using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace FiguresTests
{
    [TestClass]
    public class TriangleFigureTest
    {
        public int Seed = 71;
        public double Epsilon = 1e-10;

        [TestMethod]
        public void TriangleWrongSidesTest()
        {
            try
            {
                double a = new Random(Seed).NextDouble();
                Triangle t = new Triangle(a, a, a + 1, a + 1, a * 100, a * 100);
                Assert.Fail($"\n{t} cannot be created\n=> Triangle.CheckSides() is incorrect");

            }
            catch (Exception)
            { }
        }

        [TestMethod]
        public void RightTriangleAreaTest()
        {
            double a = new Random(Seed).NextDouble();
            Triangle t = new Triangle(0, 0, a, 0, 0, a);
            Assert.AreEqual(a * a / 2, t.GetArea(), Epsilon, $"\n{t} calculated area is wrong (should be a*a/2 = {a}*{a}/2)\n=> Triangle.GetArea() formula is incorrect");
        }

        [TestMethod]
        public void TriangleAreaFromHeightTest()
        {
            Random rnd = new Random(Seed);
            double h = rnd.NextDouble() * 5 + 1;
            double _base = rnd.NextDouble();
            double c = rnd.NextDouble() * 2;

            Triangle t = new Triangle(0, 0, _base, 0, c, h);
            Assert.AreEqual(h * _base / 2, t.GetArea(), Epsilon, $"\n{t} calculated area is wrong (should be h*_base/2 = {h}*{_base}/2)\n=> Triangle.GetArea() formula is incorrect");
        }
    }
}
