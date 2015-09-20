using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EEEEEEE;

namespace EEEEEEETests
{
    [TestFixture]
    public class EEEEEEETests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        public void EEEEEEE_String_ReturnBool(string str, bool expectedResult)
        {
            bool result = _class1.GotE(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
