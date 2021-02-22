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
    class Test_CreateFigure
    {
        [Test]
        public void Test_ExeceptionCreateTriangleSideMoreThenTwoAther()
        {
            try
            {
                Triangle triangle = new Triangle(1, 1, 5);
                Assert.Fail();
            }
            catch(Exception ex)
            {
                Assert.AreEqual(ex.Message, "Not possible: each side must be less than the sum of the other two");
            }
             
        }
        [Test]
        public void Test_ExeceptionCreateCircleRadiusLessZero()
        {
            try
            {
                Сircle triangle = new Сircle(-5);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Not possible: radius must be > 0");
            }

        }
        [Test]
        public void Test_ExeceptionSetCircleRadiusLessZero()
        {
            try
            {
                Сircle triangle = new Сircle(5);
                triangle.Radius = -4;
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Radius must be > 0");
            }

        }
        [Test]
        public void Test_ExeceptionSetTriangleSideLessZero()
        {
            try
            {
                Triangle triangle = new Triangle(2, 3, 4);
                triangle.A = -4;
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "A must be > 0");
            }

        }

    }
}
