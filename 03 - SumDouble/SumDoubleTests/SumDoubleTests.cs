using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DoubleSum;

namespace SumDoubleTests
{
    [TestFixture]
    public class SumDoubleTests
    {
        private SumDouble _sumDouble;

        [SetUp]
        public void BeforeTest()
        {
            _sumDouble = new SumDouble();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 8)]
        [TestCase(3, 2, 5)]
        public void DoubleSum_Ints_ReturnSum(int a, int b, int expectedResult)
        {
            int result = _sumDouble.DoubleSum(a, b);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
