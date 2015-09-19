using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Between10and20;

namespace Between10and20Tests
{
    [TestFixture]
    public class Between10and20Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void Between10and20_Ints_ReturnBool(int a, int b, bool expectedResult)
        {
            bool result = _class1.Between10and20(a, b);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
