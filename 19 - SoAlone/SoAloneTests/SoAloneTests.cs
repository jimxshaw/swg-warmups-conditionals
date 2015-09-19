using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SoAlone;

namespace SoAloneTests
{
    [TestFixture]
    public class SoAloneTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        public void SoAlone_Ints_ReturnBool(int a, int b, bool expectedResult)
        {
            bool result = _class1.SoAlone(a, b);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
