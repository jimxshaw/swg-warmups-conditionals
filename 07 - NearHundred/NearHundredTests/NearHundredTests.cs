using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NearHundred;

namespace NearHundredTests
{
    [TestFixture]
    public class NearHundredTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        public void NearHundred_Int_ReturnBool(int n, bool expectedResult)
        {
            bool result = _class1.NearHundred(n);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
