using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountFigureSquare;
using NUnit.Framework;

namespace UnitTestCountSquare
{
    [TestFixture]
    class Test_RightTriangle
    {
        [Test]
        public void Test_BoolRightTriangle()
        {
            Triangle triangle = new Triangle(4, 3, 5);
            Assert.AreEqual(triangle.rightTriangle, true );
            Triangle triangle1 = new Triangle(4, 3, 6);
            Assert.AreEqual(triangle1.rightTriangle, false);
            Triangle triangle2 = new Triangle(6,8, Math.Sqrt(100));
            Assert.AreEqual(triangle2.rightTriangle, true);

        }
    }
}
