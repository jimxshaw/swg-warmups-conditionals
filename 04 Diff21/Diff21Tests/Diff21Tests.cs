using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Diff21;

namespace Diff21Tests
{
    [TestFixture]
    public class Diff21Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21_Int_ReturnAbs(int n, int expectedResult)
        {
            int result = _class1.Diff21(n);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
