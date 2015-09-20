using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EndUp;

namespace EndUpTests
{
    [TestFixture]
    public class EndUpTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        public void EndUp_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _class1.EndUp(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
