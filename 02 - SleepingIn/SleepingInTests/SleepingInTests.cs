using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CanSleepIn;

namespace SleepingInTests
{
    [TestFixture]
    public class SleepingInTests
    {
        private SleepingIn _sleepingIn;

        [SetUp]
        public void BeforeTest()
        {
            _sleepingIn = new SleepingIn();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(false, false, true)]
        [TestCase(true, true, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void CanSleepIn_Bools_ReturnBool(bool isWeekday, bool isVacation, bool expectedResult)
        {
            bool result = _sleepingIn.CanSleepIn(isWeekday, isVacation);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
