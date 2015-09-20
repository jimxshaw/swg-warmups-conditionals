using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IxStart;

namespace IxStartTests
{
    [TestFixture]
    public class IxStartTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void IxStart_String_ReturnBool(string str, bool expectedResult)
        {
            bool result = _class1.IxStart(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
