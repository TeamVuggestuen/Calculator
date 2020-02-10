using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator1;

namespace Calculater.Test.Unit
{
    [TestFixture]
    public class CalculaterUnitTest
    {
        private LabCal1.Calculater uut;

        [SetUp]
        public void Setup()
        {
            uut = new LabCal1.Calculater();
        }

        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(-3, 1, -2)]
        public void Add_Add_a_and_b_return_result(int a, int b, int result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(-3, 3, -6)]
        public void Subtract_a_and_b_return_result(int a, int b, int result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(-3, -3, 9)]
        public void Multiply_a_and_b_return_result(int a, int b, int result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(15, 5, 3)]
        [TestCase(10, 2, 5)]
        [TestCase(22, 2, 11)]
        public void Divide_a_and_b_return_result(int a, int b, int result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }


        [TestCase(0, 5)]
        [TestCase(5, 0)]
        [TestCase(0, 0)]
        public void testExceptionOnDivideByZero(double a, double b)
        {
            Assert.That(() => uut.Divide(a, b), Throws.TypeOf<Calculator1.divideByZeroException>());
        }


        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        [TestCase(4, 2, 16)]
        public void Power_a_and_b_return_result(int a, int b, int result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

        [TestCase(15, 5, 20)]
        [TestCase(8, 2, 10)]
        [TestCase(1, 2, 3)]
        public void Accumulator_a_addto_B_AccResult(int a, int b, double result)
        {
            uut.Clear();
            uut.Add(a, b);
            bool sumResult = uut.Accumulator == result;
            Assert.IsTrue(sumResult);
        }

        [TestCase(15, 5, 0)]
        [TestCase(8, 2, 0)]
        [TestCase(5, 5, 0)]
        public void Accumulator_clear(int a, int b, double result)
        {
            uut.Clear();
            uut.Add(a, b);
            uut.Clear();
            bool sumResult = uut.Accumulator == result;
            Assert.IsTrue(sumResult);
        }
    }
}
 