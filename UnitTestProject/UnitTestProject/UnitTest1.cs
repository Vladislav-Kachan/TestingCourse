using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleNameSpace;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Triangle obj = new Triangle();            
            bool result = obj.IsTriangle(3,4,5);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Triangle obj = new Triangle();
            bool result = obj.IsTriangle(11, 4, 5);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Triangle obj = new Triangle();
            bool result = obj.IsTriangle(7, 8, 13);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Triangle obj = new Triangle();
            bool result = obj.IsTriangle(1, 0, 10);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Triangle obj = new Triangle();
            bool result = obj.IsTriangle(2, 2, 5);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Triangle obj = new Triangle();
            bool result = obj.IsTriangle(31, 24, 54);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Triangle obj = new Triangle();
            bool result = obj.IsTriangle(4, 4, 5);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Triangle obj = new Triangle();
            bool result = obj.IsTriangle(1, 1, 1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Triangle obj = new Triangle();
            bool result = obj.IsTriangle(8, 13, 11);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            Triangle obj = new Triangle();
            bool result = obj.IsTriangle(9, 1, 7);
            Assert.AreEqual(true, result);
        }
    }
}
