using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Max;

namespace MaxTests
{
    [TestFixture]
    public class MaxTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]
        public void Max_Ints_ReturnInt(int a, int b, int c, int expectedResult)
        {
            int result = _class1.Max(a, b, c);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
