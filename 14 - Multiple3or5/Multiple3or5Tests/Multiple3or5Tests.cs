using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Multiple3or5;

namespace Multiple3or5Tests
{
    [TestFixture]
    public class Multiple3or5Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]
        public void Multiple3or5_Int_ReturnBool(int number, bool expectedResult)
        {
            bool result = _class1.Multiple3or5(number);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
