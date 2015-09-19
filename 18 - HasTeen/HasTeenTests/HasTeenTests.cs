using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HasTeen;

namespace HasTeenTests
{
    [TestFixture]
    public class HasTeenTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void HasTeen_Ints_ReturnBool(int a, int b, int c, bool expectedResult)
        {
            bool result = _class1.HasTeen(a, b, c);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
