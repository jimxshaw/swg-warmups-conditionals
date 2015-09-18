using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PosNeg;

namespace PosNegTests
{   
    [TestFixture]
    public class PosNegTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        public void PosNeg_Bool_ReturnBool(int a, int b, bool negative, bool expectedResult)
        {
            bool result = _class1.PosNeg(a, b, negative);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
