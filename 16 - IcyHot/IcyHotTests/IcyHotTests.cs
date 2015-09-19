using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IcyHot;

namespace IcyHotTests
{
    [TestFixture]
    public class IcyHotTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        public void IcyHot_Ints_ReturnBool(int temp1, int temp2, bool expectedResult)
        {
            bool result = _class1.IcyHot(temp1, temp2);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
