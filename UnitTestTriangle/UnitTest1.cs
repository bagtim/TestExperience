using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication8;

namespace UnitTestTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTriangle()
        {
            Triangle tr = new Triangle(3, 4, 5);
            Assert.IsTrue(tr.GetRectangulared());
            Assert.AreEqual(tr.GetArea(), 6);

            Triangle tr1 = new Triangle(2, 2, 5);
            Assert.IsFalse(tr1.GetRectangulared());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Test exception of value")]
        public void TestTriangleException()
        {
            new Triangle(0, 0, 0);
            new Triangle(0, 0, 1);
            new Triangle(0, 1, 0);
            new Triangle(1, 0, 0);
        }
    }
}
