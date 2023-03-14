using Mindbox.Task;
using NUnit.Framework;
using System;

namespace Mindbox.Tests
{
    public class TestTriangle
    {
        [Test]
        public void NegativeSideTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 3, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(3, -1, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(3, 3, -1));
        }

        [Test]
        public void ZeroSideTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 3, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(3, 0, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(3, 3, 0));
        }

        [Test]
        public void TriangleFormTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(2, 10, 2));
            Assert.Throws<ArgumentException>(() => new Triangle(10, 2, 2));
            Assert.Throws<ArgumentException>(() => new Triangle(2, 2, 10));
        }

        [Test]
        public void GetAreaTest()
        {
            double testVar = new Triangle(3, 10, 12).GetArea();

            Assert.AreEqual(12.183492931011205, testVar);
        }

        [Test]
        public void IsRightTriangleTest()
        {
            bool testVar = new Triangle(3, 4, 5).IsRight;

            Assert.True(testVar);
        }

        [Test]
        public void IsNotRightTriangleTest()
        {
            bool testVar = new Triangle(2, 4, 5).IsRight;

            Assert.False(testVar);
        }
    }
}
