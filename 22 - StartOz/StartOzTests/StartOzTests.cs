using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StartOz;

namespace StartOzTests
{
    [TestFixture]
    public class StartOzTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        public void StartOz_String_ReturnSubstring(string str, string expectedResult)
        {
            string result = _class1.StartOz(str);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
