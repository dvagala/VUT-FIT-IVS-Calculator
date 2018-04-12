using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;
namespace MathLibraryTest
{

    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void MathLibrary_add()
        {
            var sut = new matho();
            Assert.AreEqual(sut.add(3, 5), 8);
            Assert.AreEqual(sut.add(-7, 1897), 1890);
            Assert.AreEqual(sut.add(3.245, 5.245), 8.490);
            Assert.AreEqual(sut.add(-56894, 56894), 0);


        }
        [TestMethod]
        public void MathLibrary_sub()
        {
            var sut = new matho();
            Assert.AreEqual(sut.sub(3, 5), -2);
            Assert.AreEqual(sut.sub(-7, 1897), -1904);
            Assert.AreEqual(sut.sub(8.245, 5.240), 3, 005);
            Assert.AreEqual(sut.sub(456789, 456789), 0);


        }

        [TestMethod]
        public void MathLibrary_mul()
        {
            var sut = new matho();
            Assert.AreEqual(sut.mul(3, 5), 15);
            Assert.AreEqual(sut.mul(-7, 1897), -13279);
            Assert.AreEqual(sut.mul(8.245, 5.240), 43, 2038);
            Assert.AreEqual(sut.mul(456789, 456789), 208656190521);


        }
        [TestMethod]
        public void MathLibrary_div()
        {
            var sut = new matho();
            Assert.AreEqual(sut.div(15, 3), 5);
            Assert.AreEqual(sut.div(1897, 8), 237, 125);
            Assert.AreEqual(sut.div(8.245, 1.25), 6, 596);
            Assert.AreEqual(sut.div(456789, 456789), 1);


        }

        [TestMethod]
        public void MathLibrary_Fakt()
        {
            var sut = new matho();
            Assert.AreEqual(sut.fakt(5), 120);
            Assert.AreEqual(sut.fakt(-5), -1);
            Assert.AreEqual(sut.fakt(2.5), -1);
            Assert.AreEqual(sut.fakt(11), 39916800);
            Assert.AreEqual(sut.fakt(0), 1);


        }
        [TestMethod]
        public void MathLibrary_Root()
        {
            var sut = new matho();
            Assert.AreEqual(sut.root(2,2),4);
            Assert.AreEqual(sut.root(0,2),0);
            Assert.AreEqual(sut.root(1,10),1);
            Assert.AreEqual(sut.root(7,9), 40353607);
            

        }
        [TestMethod]
        public void MathLibrary_SquareRoot()
        {
            var sut = new matho();
            Assert.AreEqual(sut.square_root(4), 2);
            Assert.AreEqual(sut.square_root(5), 2,23606797749979);
            Assert.AreEqual(sut.square_root(0), 0);
            Assert.AreEqual(sut.square_root(-5), -1);
            Assert.AreEqual(sut.square_root(2.2), 1,48323969741913);

        }
        [TestMethod]
        public void MathLibrary_Mod()
        {
            var sut = new matho();
            Assert.AreEqual(sut.mod(7,2), 1);
            Assert.AreEqual(sut.mod(8,2), 0);
            Assert.AreEqual(sut.mod(45678,12315), 8733);
            Assert.AreEqual(sut.mod(6.99999,7), 6,99999);

        }
        
    }
}
