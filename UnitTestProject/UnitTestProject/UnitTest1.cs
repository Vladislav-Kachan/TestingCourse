using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleNameSpace;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TrianglNormal()
        {
            Assert.IsTrue(Triangle.IsTriangle(3,4,5));
        }

        [TestMethod]
        public void TrianglWithOneLarge()
        {
            Assert.IsFalse(Triangle.IsTriangle(11, 4, 5));
        }

        [TestMethod]
        public void TrianglNormalTo()
        {
            Assert.IsTrue(Triangle.IsTriangle(7, 8, 13));
        }

        [TestMethod]
        public void TrianglWithOneZeroSide()
        {
            Assert.IsFalse(Triangle.IsTriangle(1, 0, 10));
        }

        [TestMethod]
        public void TrianglTwoSide()
        {
            Assert.IsFalse(Triangle.IsTriangle(2, 2, 5));
        }

        [TestMethod]
        public void NormalTriangl()
        {
            Assert.IsTrue(Triangle.IsTriangle(31, 24, 54));
        }

        [TestMethod]
        public void TrianglWithSideMineZero()
        {
            Assert.IsTrue(Triangle.IsTriangle(-1, 4, 5));
        }

        [TestMethod]
        public void TriangleWithThreeEqulSide()
        {
            Assert.IsTrue(Triangle.IsTriangle(1, 1, 1));
        }

        [TestMethod]
        public void ToNormalTriangl()
        {
            Assert.IsTrue(Triangle.IsTriangle(8, 13, 11));
        }

        [TestMethod]
        public void TrianglWithZeroSides()
        {
            Assert.IsFalse(Triangle.IsTriangle(0, 0, 0));
        }
    }
}
