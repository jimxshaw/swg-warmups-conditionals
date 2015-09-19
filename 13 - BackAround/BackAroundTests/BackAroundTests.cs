using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BackAround;

namespace BackAroundTests
{
    [TestFixture]
    public class BackAroundTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAround_String_ReturnConcatenation(string str, string expectedResult)
        {
            string result = _class1.BackAround(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
