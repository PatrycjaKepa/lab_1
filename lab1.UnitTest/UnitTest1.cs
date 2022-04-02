using lab_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab1.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfConstructorZeroArgumentsWorksCorrectly()
        {
            var fraction = new Fraction();
            Assert.AreEqual(fraction.Numerator, (uint)0, "default value is not zero");
            Assert.AreEqual(fraction.Denominator, (uint)0, "default value is not zero");
        }
        
        [TestMethod]
        public void TestIfConstructorTwoArgumentsWorksCorrectly()
        {
            var fraction = new Fraction(20, 30);
            Assert.AreEqual(fraction.Numerator, (uint)20, "bad value");
            Assert.AreEqual(fraction.Denominator, (uint)30, "bad value");
        }

        [TestMethod]
        public void TestIfConstructorOneArgumentWorksCorrectly()
        {
            var fraction = new Fraction(20, 30);
            var fractionCopy = new Fraction(fraction);

            Assert.AreEqual(fractionCopy.Numerator, (uint)20, "bad copied value");
            Assert.AreEqual(fractionCopy.Denominator, (uint)30, "bad copied value");
        }

        [TestMethod]
        public void ToStringTest()
        {
            var fraction = new Fraction(2, 5);
            Assert.AreEqual(fraction.ToString(),"Ułamek: 2/5");
        }

        [TestMethod]
        public void OperatorPlusTest()
        {
            var fraction1 = new Fraction(2, 5);
            var fraction2 = new Fraction(3, 10);
            Assert.AreEqual((fraction1 + fraction2).Equals(new Fraction(7, 10)), true, "bad value");
        }

        [TestMethod]
        public void OperatorMinusTest()
        {
            var fraction1 = new Fraction(2, 5);
            var fraction2 = new Fraction(3, 10);
            Assert.AreEqual((fraction1 - fraction2).Equals(new Fraction(1, 10)), true, "bad value");
        }

        [TestMethod]
        public void OperatorMultiplicationTest()
        {
            var fraction1 = new Fraction(2, 5);
            var fraction2 = new Fraction(3, 10);
            Assert.AreEqual((fraction1 * fraction2).Equals(new Fraction(6, 50)), true, "bad value");
        }

        [TestMethod]
        public void OperatorDivisionTest()
        {
            var fraction1 = new Fraction(2, 5);
            var fraction2 = new Fraction(3, 10);
            Assert.AreEqual((fraction1 / fraction2).Equals(new Fraction(20, 15)), true, "bad value");
        }
        [TestMethod]
        public void TestEquals()
        {
            var fraction1 = new Fraction(1, 3);
            var fraction2 = new Fraction(2, 3);
            Assert.IsFalse(fraction1.Equals(fraction2));
        }

        [TestMethod]
        public void TestComparable()
        {
            var fraction1 = new Fraction(2, 5);
            var fraction2 = new Fraction(3, 10);
            Assert.AreEqual(fraction1.CompareTo(fraction2), 1);
        }

        [TestMethod]
        public void TestToIntFloor()
        {
            var fraction1 = new Fraction(1, 3);
            Assert.AreEqual(fraction1.ToIntFloor(), 0);
        }

        [TestMethod]
        public void TestToIntCeil()
        {
            var fraction1 = new Fraction(1, 3);
            Assert.AreEqual(fraction1.ToIntCeil(), 1);
        }
    }
}