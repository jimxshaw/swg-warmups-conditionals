using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FrontBack;

namespace FrontBackTests
{
    [TestFixture]
    public class FrontBackTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        public void FrontBack_String_ReturnString(string str, string expectedResult)
        {
            string result = _class1.FrontBack(str);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
