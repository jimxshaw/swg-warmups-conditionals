using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StartHi;

namespace StartHiTests
{
    [TestFixture]
    public class StartHiTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]
        public void StartHi_String_ReturnBool(string str, bool expectedResult)
        {
            bool result = _class1.StartHi(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
