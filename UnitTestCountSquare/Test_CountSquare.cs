using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountFigureSquare;

namespace UnitTestCountSquare
{
    [TestFixture]
    class Test_CountSquare
    {
        [Test]
        public void Test_CountSquareTriangle()
        {
            Triangle triangle = new Triangle(4, 3, 3);
            Assert.AreEqual(triangle.CountSquare(), Math.Sqrt(5 * (5 - 4) * (5 - 3) * (5 - 3)));
            Triangle triangle1 = new Triangle(3, 2, 3);
            Assert.AreEqual(triangle1.CountSquare(), Math.Sqrt(4 * (4 - 3) * (4 - 2) * (4 - 3)));
        }
        [Test]
        public void Test_CountSquareCircle()
        {
            Сircle circle = new Сircle(4);
            Assert.AreEqual(circle.CountSquare(), 3.14159 * 4 * 4);
            Сircle circle2 = new Сircle(5);
            Assert.AreEqual(circle2.CountSquare(), 3.14159 * 5 * 5);
        }
    }
}
