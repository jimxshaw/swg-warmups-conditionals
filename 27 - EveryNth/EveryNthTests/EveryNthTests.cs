using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EveryNth;

namespace EveryNthTests
{
    [TestFixture]
    public class EveryNthTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        public void EveryNth_String_ReturnString(string str, int n, string expectedResult)
        {
            string result = _class1.EveryNth(str, n);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
