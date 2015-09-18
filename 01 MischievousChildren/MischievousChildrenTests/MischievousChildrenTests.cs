using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AreWeInTrouble;

namespace MischievousChildrenTests
{
    [TestFixture]
    public class MischievousChildrenTests
    {
        private MischievousChildren _mischievousChildren;

        [SetUp]
        public void BeforeTest()
        {
            _mischievousChildren = new MischievousChildren();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, false)]
        public void AreWeInTrouble_Bools_ReturnBool(bool aSmile, bool bSmile, bool expectedResult)
        {
            bool result = _mischievousChildren.AreWeInTrouble(aSmile, bSmile);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
