using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Front3;

namespace Front3Tests
{
    [TestFixture]
    public class Front3Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]
        public void Front3_String_ReturnSubstring(string str, string expectedResults)
        {
            string result = _class1.Front3(str);

            Assert.AreEqual(result, expectedResults);
        }
    }
}
