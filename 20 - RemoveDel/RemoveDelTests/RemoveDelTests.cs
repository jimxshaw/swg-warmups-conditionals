using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RemoveDel;

namespace RemoveDelTests
{
    [TestFixture]
    public class RemoveDelTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        public void RemoveDel_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _class1.RemoveDel(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
