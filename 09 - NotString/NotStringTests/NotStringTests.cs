using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NotString;

namespace NotStringTests
{
    [TestFixture]
    public class NotStringTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotString_String_ReturnConcatenation(string str, string expectedResult)
        {
            string result = _class1.NotString(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
