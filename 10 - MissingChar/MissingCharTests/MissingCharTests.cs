using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MissingChar;

namespace MissingCharTests
{
    [TestFixture]
    public class MissingCharTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingChar_String_ReturnSubstring(string str, int n, string expectedResult)
        {
            string result = _class1.MissingChar(str, n);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
