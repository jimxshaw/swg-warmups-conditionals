using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ParrotTrouble;

namespace ParrotTroubleTests
{
    [TestFixture]
    public class ParrotTroubleTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 37, false)]
        [TestCase(false, -9, false)]
        [TestCase(true, 13, false)]
        [TestCase(false, 22, false)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTrouble_Int_ReturnBool(bool isTalking, int hour, bool expectedResult)
        {
            bool result = _class1.ParrotTrouble(isTalking, hour);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
