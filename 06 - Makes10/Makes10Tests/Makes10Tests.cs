using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Makes10;

namespace Makes10Tests
{
    [TestFixture]
    public class Makes10Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(9, 10, true)]
        [TestCase(1, 9, true)]
        [TestCase(9, 9, false)]
        public void Makes10_Ints_ReturnBool(int a, int b, bool expectedResult)
        {
            bool result = _class1.Makes10(a, b);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
