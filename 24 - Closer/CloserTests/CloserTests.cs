using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Closer;

namespace CloserTests
{
    [TestFixture]
    public class CloserTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]
        public void Closer_Ints_ReturnInt(int a, int b, int expectedResult)
        {
            int result = _class1.Closer(a, b);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
