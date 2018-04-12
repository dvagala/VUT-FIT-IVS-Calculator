using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;
namespace MathLibraryTest
{

    [TestClass]
    public class MathLibraryTest
    {


        [TestMethod]
        public void MathLibraryAdd()
        {
            var sut = new matho();
            Assert.AreEqual(sut.Add(3, 5), 8);
            Assert.AreEqual(sut.Add(-7, 1897), 1890);
            Assert.AreEqual(sut.Add(3.245, 5.245), 8.490);
            Assert.AreEqual(sut.Add(-56894, 56894), 0);


        }
        [TestMethod]
        public void MathLibrarySub()
        {
            var sut = new matho();
            Assert.AreEqual(sut.Sub(3, 5), -2);
            Assert.AreEqual(sut.Sub(-7, 1897), -1904);
            Assert.AreEqual(sut.Sub(8.245, 5.240), 3, 005);
            Assert.AreEqual(sut.Sub(456789, 456789), 0);


        }

        [TestMethod]
        public void MathLibraryMul()
        {
            var sut = new matho();
            Assert.AreEqual(sut.Mul(3, 5), 15);
            Assert.AreEqual(sut.Mul(-7, 1897), -13279);
            Assert.AreEqual(sut.Mul(8.245, 5.240), 43, 2038);
            Assert.AreEqual(sut.Mul(456789, 456789), 208656190521);


        }
        [TestMethod]
        public void MathLibraryDiv()
        {
            var sut = new matho();
            Assert.AreEqual(sut.Div(15, 3), 5);
            Assert.AreEqual(sut.Div(1897, 8), 237, 125);
            Assert.AreEqual(sut.Div(8.245, 1.25), 6, 596);
            Assert.AreEqual(sut.Div(456789, 456789), 1);


        }

        [TestMethod]
        public void MathLibraryFakt()
        {
            var sut = new matho();
            Assert.AreEqual(sut.Fakt(5), 120);
            Assert.AreEqual(sut.Fakt(-5), -1);
            Assert.AreEqual(sut.Fakt(2.5), -1);
            Assert.AreEqual(sut.Fakt(11), 39916800);
            Assert.AreEqual(sut.Fakt(0), 1);


        }
        [TestMethod]
        public void MathLibraryRoot()
        {
            var sut = new matho();
            Assert.AreEqual(sut.Root(2,2),4);
            Assert.AreEqual(sut.Root(0,2),0);
            Assert.AreEqual(sut.Root(1,10),1);
            Assert.AreEqual(sut.Root(7,9), 40353607);
            

        }
        [TestMethod]
        public void MathLibrarySquareRoot()
        {
            var sut = new matho();
            Assert.AreEqual(sut.SquareRoot(4), 2);
            Assert.AreEqual(sut.SquareRoot(5), 2,23606797749979);
            Assert.AreEqual(sut.SquareRoot(0), 0);
            Assert.AreEqual(sut.SquareRoot(-5), -1);
            Assert.AreEqual(sut.SquareRoot(2.2), 1,48323969741913);

        }
        [TestMethod]
        public void MathLibraryMod()
        {
            var sut = new matho();
            Assert.AreEqual(sut.Mod(7,2), 1);
            Assert.AreEqual(sut.Mod(8,2), 0);
            Assert.AreEqual(sut.Mod(45678,12315), 8733);
            Assert.AreEqual(sut.Mod(6.99999,7), 6,99999);

        }
        
    }
}
