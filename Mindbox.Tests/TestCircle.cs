using Mindbox.Task;
using NUnit.Framework;
using System;

namespace Mindbox.Tests
{
    public class TestCircle
    {

        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void GetAreaTest()
        {
            double testVar = new Circle(5).GetArea();

            Assert.AreEqual(78.53981633974483, testVar);
        }
    }
}